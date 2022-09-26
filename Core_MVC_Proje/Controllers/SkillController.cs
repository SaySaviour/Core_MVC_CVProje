using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
