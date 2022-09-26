using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
