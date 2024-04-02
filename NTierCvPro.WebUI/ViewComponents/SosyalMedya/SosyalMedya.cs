using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.ViewComponents.SosyalMedya
{
    public class SosyalMedya : ViewComponent
    {
        private readonly ISosyalMedyaService _sosyalMedyaService;

        public SosyalMedya(ISosyalMedyaService sosyalMedyaService)
        {
            _sosyalMedyaService = sosyalMedyaService;
        }

        public IViewComponentResult Invoke()
        {
            var sosyalMedya = _sosyalMedyaService.TGetList().Where(x => x.Durum == true).ToList();
            return View(sosyalMedya);
        }
    }
}
