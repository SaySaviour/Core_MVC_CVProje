using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_MVC_Proje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager messageManager=new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message message)
        //{
        //    message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    message.Status = true.ToString();
        //    messageManager.TAdd(message);
        //    return View();
        //}
    }
}
