using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
