using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatik Sayfası";
            return View();
        }
    }
}
