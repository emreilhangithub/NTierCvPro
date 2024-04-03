using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class SosyalMedyaController : Controller
    {
        private readonly ISosyalMedyaService _sosyalMedyaService;

        public SosyalMedyaController(ISosyalMedyaService sosyalMedyaService)
        {
            _sosyalMedyaService = sosyalMedyaService;
        }

        public IActionResult Index()
        {
            var veriler = _sosyalMedyaService.TGetList();
            return View(veriler);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(SosyalMedya p)
        {
            _sosyalMedyaService.TInsert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult SayfaGetir(int id)
        {
            var hesap = _sosyalMedyaService.TFind(x => x.ID == id);
            return View(hesap);
        }

        [HttpPost]
        public IActionResult SayfaGetir(SosyalMedya t)
        {
            var hesap = _sosyalMedyaService.TFind(x => x.ID == t.ID);
            hesap.Ad = t.Ad;
            hesap.Link = t.Link;
            hesap.Ikon = t.Ikon;
            hesap.Durum = true;
            _sosyalMedyaService.TUpdate(hesap);
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int id)
        {
            var hesap = _sosyalMedyaService.TFind(x => x.ID == id);
            hesap.Durum = false;
            _sosyalMedyaService.TUpdate(hesap);
            return RedirectToAction("Index");
        }
    }
}
