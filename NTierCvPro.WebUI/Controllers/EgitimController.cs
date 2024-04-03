using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class EgitimController : Controller
    {
        private readonly IEgitimlerimService _egitimlerimService;

        public EgitimController(IEgitimlerimService egitimlerimService)
        {
            _egitimlerimService = egitimlerimService;
        }

        public IActionResult Index()
        {
            var egitimlerim = _egitimlerimService.TGetList();
            return View(egitimlerim);
        }
        [HttpGet]
        public IActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EgitimEkle(Egitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }

            _egitimlerimService.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult EgitimSil(int id)
        {
            var egitim = _egitimlerimService.TFind(x => x.ID == id);
            _egitimlerimService.TDelete(egitim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EgitimDuzenle(int id)
        {
            var egitim = _egitimlerimService.TFind(x => x.ID == id);
            return View(egitim);
        }
        [HttpPost]
        public IActionResult EgitimDuzenle(Egitimlerim t)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }

            var egitim = _egitimlerimService.TFind(x => x.ID == t.ID);
            egitim.Baslik = t.Baslik;
            egitim.AltBalik1 = t.Baslik;
            egitim.AltBaslik2 = t.Baslik;
            egitim.Tarih = t.Tarih;
            egitim.GNO = t.GNO;
            _egitimlerimService.TUpdate(egitim);
            return RedirectToAction("Index");
        }
    }
}
