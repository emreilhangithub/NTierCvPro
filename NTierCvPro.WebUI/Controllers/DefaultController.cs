using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.Controllers
{
    [AllowAnonymous] //yetkisiz sayfa açılabilir.
    public class DefaultController : Controller
    {
        private readonly IHakkimdaService _hakkimdaService;
        private readonly IDeneyimlerimService _deneyimlerimService;
        private readonly ISosyalMedyaService _sosyalMedyaService;
        private readonly IEgitimlerimService _egitimlerimService;
        private readonly IYeteneklerimService _yeteneklerimService;
        private readonly IHobilerimService _hobilerimService;
        private readonly ISertifikalarimService _sertifikalarimService;
        private readonly IIletisimService _iletisimService;
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(IHakkimdaService hakkimdaService, IDeneyimlerimService deneyimlerimService, ISosyalMedyaService sosyalMedyaService, IEgitimlerimService egitimlerimService, IYeteneklerimService yeteneklerimService, IHobilerimService hobilerimService, ISertifikalarimService sertifikalarimService, IIletisimService iletisimService, ILogger<DefaultController> logger)
        {
            _hakkimdaService = hakkimdaService;
            _deneyimlerimService = deneyimlerimService;
            _sosyalMedyaService = sosyalMedyaService;
            _egitimlerimService = egitimlerimService;
            _yeteneklerimService = yeteneklerimService;
            _hobilerimService = hobilerimService;
            _sertifikalarimService = sertifikalarimService;
            _iletisimService = iletisimService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var degerler = _hakkimdaService.TGetList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = _deneyimlerimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalMedya = _sosyalMedyaService.TGetList().Where(x => x.Durum == true).ToList();
            return PartialView(sosyalMedya);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = _egitimlerimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = _yeteneklerimService.TGetList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = _hobilerimService.TGetList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = _sertifikalarimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return PartialView(sertifikalar);
        }

        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }

        //[HttpPost]
        //public PartialViewResult Iletisim(Tbl_Iletisim t)
        //{
        //    t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
        //    db.Tbl_Iletisim.Add(t);
        //    db.SaveChanges();
        //    return PartialView();
        //}
    }
}
