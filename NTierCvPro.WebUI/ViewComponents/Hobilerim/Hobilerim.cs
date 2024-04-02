using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.ViewComponents.Hobilerim
{
    public class Hobilerim : ViewComponent
    {
        private readonly IHobilerimService _hobilerimService;

        public Hobilerim(IHobilerimService hobilerimService)
        {
            _hobilerimService = hobilerimService;
        }

        public IViewComponentResult Invoke()
        {
            var hobiler = _hobilerimService.TGetList();
            return View(hobiler);
        }
    }
}
