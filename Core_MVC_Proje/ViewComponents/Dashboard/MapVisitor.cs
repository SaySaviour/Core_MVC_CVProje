using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.ViewComponents.Dashboard
{
	public class MapVisitor:ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
