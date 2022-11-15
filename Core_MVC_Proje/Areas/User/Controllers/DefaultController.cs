using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.Areas.Writer.Controllers
{
    public class DefaultController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
