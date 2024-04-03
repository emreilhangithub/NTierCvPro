using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;
using NTierCvPro.WebUI.ViewComponents.Deneyim;

namespace NTierCvPro.WebUI.Controllers
{
    public class DeneyimController : Controller
    {
        private readonly IDeneyimlerimService _deneyimlerimService;

        public DeneyimController(IDeneyimlerimService deneyimlerimService)
        {
            _deneyimlerimService = deneyimlerimService;
        }

        public IActionResult Index()
        {
            var degerler = _deneyimlerimService.TGetList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeneyimEkle(Deneyimlerim p)
        {
            _deneyimlerimService.TInsert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeneyimSil(int id)
        {
            var deneyim = _deneyimlerimService.TFind(x => x.ID == id);
            _deneyimlerimService.TDelete(deneyim);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeneyimGetir(int id)
        {
            var deneyim = _deneyimlerimService.TFind(x => x.ID == id);
            return View(deneyim);
        }

        [HttpPost]
        public IActionResult DeneyimGetir(Deneyimlerim t)
        {
            var deneyim = _deneyimlerimService.TFind(x => x.ID == t.ID);
            deneyim.Baslik = t.Baslik;
            deneyim.AltBaslik = t.AltBaslik;
            deneyim.Tarih = t.Tarih;
            deneyim.Aciklama = t.Aciklama;
            _deneyimlerimService.TUpdate(deneyim);
            return RedirectToAction("Index");
        }
    }
}
