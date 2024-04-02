using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.ViewComponents.Sertifikalar
{
    public class Sertifikalar : ViewComponent
    {
        private readonly ISertifikalarimService _sertifikalarimService;

        public Sertifikalar(ISertifikalarimService sertifikalarimService)
        {
            _sertifikalarimService = sertifikalarimService;
        }

        public IViewComponentResult Invoke()
        {
            var sertifikalar = _sertifikalarimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return View(sertifikalar);
        }
    }
}
