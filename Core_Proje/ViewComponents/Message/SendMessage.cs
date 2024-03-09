using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Core_Proje.ViewComponents.Message
{
    public class SendMessage : ViewComponent
    {
        private MessageManager mng = new MessageManager(new EfMessageDal());

        public IViewComponentResult Invoke()
        {
            
            return View();
        }

        



        //[HttpPost]
        //public IViewComponentResult Invoke(EntityLayer.Concrete.Message m)
        //{
        //    m.Date = DateTime.Now;
        //    m.Status = false;
        //    mng.TAdd(m);
        //    return View();
        //}
    }
}
