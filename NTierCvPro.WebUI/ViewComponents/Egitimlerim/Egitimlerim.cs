using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;

namespace NTierCvPro.WebUI.ViewComponents.Egitimlerim
{
    public class Egitimlerim : ViewComponent
    {
        private readonly IEgitimlerimService _egitimlerimService;

        public Egitimlerim(IEgitimlerimService egitimlerimService)
        {
            _egitimlerimService = egitimlerimService;
        }

        public IViewComponentResult Invoke()
        {
            var egitimler = _egitimlerimService.TGetList().OrderByDescending(x => x.ID).ToList();
            return View(egitimler);
        }
    }
}
