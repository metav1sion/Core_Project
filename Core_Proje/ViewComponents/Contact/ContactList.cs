using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {
        private ContactManager mng = new ContactManager(new EfContactDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
