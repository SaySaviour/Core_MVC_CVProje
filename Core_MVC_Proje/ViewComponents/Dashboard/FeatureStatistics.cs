using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_MVC_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x=>x.Status=="False").Count();
            ViewBag.v3 = c.Messages.Where(x=>x.Status=="True").Count();
            ViewBag.v4 = c.Experiences.Count();
            return View();
        }

    }
}
