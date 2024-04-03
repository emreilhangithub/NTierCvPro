using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class YetenekController : Controller
    {
        private readonly IYeteneklerimService _yeteneklerimService;

        public YetenekController(IYeteneklerimService yeteneklerimService)
        {
            _yeteneklerimService = yeteneklerimService;
        }

        public IActionResult Index()
        {
            var yetenekler = _yeteneklerimService.TGetList();
            return View(yetenekler);
        }
        [HttpGet]
        public IActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniYetenek(Yeteneklerim p)
        {
            _yeteneklerimService.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult YetenekSil(int id)
        {
            var yetenek = _yeteneklerimService.TFind(x => x.ID == id);
            _yeteneklerimService.TDelete(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult YetenekDuzenle(int id)
        {
            var yetenek = _yeteneklerimService.TFind(x => x.ID == id);
            return View(yetenek);
        }

        [HttpPost]
        public IActionResult YetenekDuzenle(Yeteneklerim t)
        {
            var yetenek = _yeteneklerimService.TFind(x => x.ID == t.ID);
            yetenek.Yetenek = t.Yetenek;
            yetenek.Oran = t.Oran;
            _yeteneklerimService.TUpdate(yetenek);
            return RedirectToAction("Index");
        }
    }
}
