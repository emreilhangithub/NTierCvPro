using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    [AllowAnonymous] //yetkisiz sayfa açılabilir.
    public class DefaultController : Controller
    {
        private readonly IHakkimdaService _hakkimdaService;       
        private readonly IIletisimService _iletisimService;
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(IHakkimdaService hakkimdaService,IIletisimService iletisimService, ILogger<DefaultController> logger)
        {
            _hakkimdaService = hakkimdaService;
            _iletisimService = iletisimService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var degerler = _hakkimdaService.TGetList();
            return View(degerler);
        }

        [HttpPost]
        public IActionResult Iletisim(Iletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            _iletisimService.TInsert(t);
            return PartialView();
        }
    }
}
