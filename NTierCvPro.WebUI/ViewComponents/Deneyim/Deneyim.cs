using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.ViewComponents.Deneyim
{
    public class Deneyim : ViewComponent
    {
        private readonly IDeneyimlerimService _deneyimlerimService;

        public Deneyim(IDeneyimlerimService deneyimlerimService)
        {
            _deneyimlerimService = deneyimlerimService;
        }

        public IViewComponentResult Invoke()
        {
            var deneyimler = _deneyimlerimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return View(deneyimler);
        }
    }
}
