using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpPost] // Sadece POST isteklerini kabul eden metot
        public IActionResult SendMessageToDatabase(EntityLayer.Concrete.Message message)
        {
            MessageManager mng = new MessageManager(new EfMessageDal());

            
                message.Date = DateTime.Now;
                message.Status = false;
                mng.TAdd(message); // Mesajı veritabanına kaydet
                return Redirect("/Default/Index#contact");
            
            
        }
    }
}
