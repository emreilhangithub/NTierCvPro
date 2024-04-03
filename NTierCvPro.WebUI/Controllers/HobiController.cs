using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class HobiController : Controller
    {
        private readonly IHobilerimService _hobilerimService;

        public HobiController(IHobilerimService hobilerimService)
        {
            _hobilerimService = hobilerimService;
        }

        public IActionResult Index()
        {
            var hobi = _hobilerimService.TGetList();
            return View(hobi);
        }
        [HttpGet]
        public IActionResult HobiEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HobiEkle(Hobilerim p)
        {
            _hobilerimService.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult HobiSil(int id)
        {
            var hobi = _hobilerimService.TFind(x => x.ID == id);
            _hobilerimService.TDelete(hobi);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult HobiDuzenle(int id)
        {
            var hobi = _hobilerimService.TFind(x => x.ID == id);
            return View(hobi);
        }

        [HttpPost]
        public IActionResult HobiDuzenle(Hobilerim t)
        {
            var hobi = _hobilerimService.TFind(x => x.ID == t.ID);
            hobi.Aciklama1 = t.Aciklama1;
            hobi.Aciklama2 = t.Aciklama2;
            _hobilerimService.TUpdate(hobi);
            return RedirectToAction("Index");
        }
    }
}
