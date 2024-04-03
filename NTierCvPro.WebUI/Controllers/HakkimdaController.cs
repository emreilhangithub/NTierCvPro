using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class HakkimdaController : Controller
    {
        private readonly IHakkimdaService _hakkimdaService;

        public HakkimdaController(IHakkimdaService hakkimdaService)
        {
            _hakkimdaService = hakkimdaService;
        }

        public IActionResult Index()
        {
            var hakkimda = _hakkimdaService.TGetList();
            return View(hakkimda);
        }
        [HttpPost]
        public IActionResult Index(Hakkimda t)
        {
            var hakkimda = _hakkimdaService.TFind(x => x.ID == 1); //ilkini getirdik
            hakkimda.Ad = t.Ad;
            hakkimda.Soyad = t.Soyad;
            hakkimda.Adres = t.Adres;
            hakkimda.Mail = t.Mail;
            hakkimda.Telefon = t.Telefon;
            hakkimda.Aciklama = t.Aciklama;
            hakkimda.Resim = t.Resim;
            _hakkimdaService.TUpdate(hakkimda);
            return RedirectToAction("Index");
        }
    }
}
