using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        private ServiceManager mng = new ServiceManager(new EfServiceDal());
        
        public IActionResult Index()
        {
            var values = mng.TGetList();
            return View(values);
        }
        
        public IActionResult DeleteService(int id)
        {
            mng.TDelete(mng.TGetByID(id));
            return RedirectToAction("Index");
        }
    }
}
