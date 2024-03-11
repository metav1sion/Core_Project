using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager mng = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = mng.TGetByID(7);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            mng.TUpdate(p);
            return RedirectToAction("Index","Default");
        }
    }
}
