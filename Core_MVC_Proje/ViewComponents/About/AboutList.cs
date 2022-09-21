using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Core_MVC_Proje.ViewComponents.About
{
	public class AboutList:ViewComponent
	{
		AboutManager aboutManager=new AboutManager(new EfAboutDal());
		public ViewViewComponentResult Invoke()
		{
			var values = aboutManager.GetList();
			return View(values);
		}
	}
}
