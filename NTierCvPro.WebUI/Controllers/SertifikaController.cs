using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class SertifikaController : Controller
    {
        private readonly ISertifikalarimService _sertifikalarimService;

        public SertifikaController(ISertifikalarimService sertifikalarimService)
        {
            _sertifikalarimService = sertifikalarimService;
        }

        public IActionResult Index()
        {
            var sertifika = _sertifikalarimService.TGetList();
            return View(sertifika);
        }
        [HttpGet]
        public IActionResult SertifikaGetir(int id)
        {
            var sertifika = _sertifikalarimService.TFind(x => x.ID == id);
            ViewBag.SertifikaId = id;
            return View(sertifika);
        }

        [HttpPost]
        public IActionResult SertifikaGetir(Sertifikalarim t)
        {
            var sertifika = _sertifikalarimService.TFind(x => x.ID == t.ID);
            sertifika.Aciklama = t.Aciklama;
            sertifika.Tarih = t.Tarih;
            _sertifikalarimService.TUpdate(sertifika);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniSertifika(Sertifikalarim p)
        {
            _sertifikalarimService.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult SertifikaSil(int id)
        {
            var sertifika = _sertifikalarimService.TFind(x => x.ID == id);
            _sertifikalarimService.TDelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}
