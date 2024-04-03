using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.Controllers
{
    public class IletisimController : Controller
    {
        private readonly IIletisimService _iletisimService;

        public IletisimController(IIletisimService iletisimService)
        {
            _iletisimService = iletisimService;
        }

        public IActionResult Index()
        {
            var mesajlar = _iletisimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return View(mesajlar);
        }
        public IActionResult MesajSil(int id)
        {
            var mesaj = _iletisimService.TFind(x => x.ID == id);
            _iletisimService.TDelete(mesaj);
            return RedirectToAction("Index");
        }
    }
}
