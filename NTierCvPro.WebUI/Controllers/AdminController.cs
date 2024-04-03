using Microsoft.AspNetCore.Mvc;
using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var liste = _adminService.TGetList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminEkle(Admin p)
        {
            _adminService.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult AdminSil(int id)
        {
            var admin = _adminService.TFind(x => x.ID == id);
            _adminService.TDelete(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AdminDuzenle(int id)
        {
            var admin = _adminService.TFind(x => x.ID == id);
            return View(admin);
        }

        [HttpPost]
        public IActionResult AdminDuzenle(Admin t)
        {
            var admin = _adminService.TFind(x => x.ID == t.ID);
            admin.KullaniciAdi = t.KullaniciAdi;
            admin.Sifre = t.Sifre;
            _adminService.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}
