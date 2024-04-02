using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.ViewComponents.Yeteneklerim
{
    public class Yeteneklerim : ViewComponent
    {

        private readonly IYeteneklerimService _yeteneklerimService;

        public Yeteneklerim(IYeteneklerimService yeteneklerimService)
        {
            _yeteneklerimService = yeteneklerimService;
        }

        public IViewComponentResult Invoke()
        {
            var yetenekler = _yeteneklerimService.TGetList();
            return View(yetenekler);
        }
    }
}
