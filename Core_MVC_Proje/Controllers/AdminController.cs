using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
