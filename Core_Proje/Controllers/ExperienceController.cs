using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        private ExperienceManager mng = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = mng.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            mng.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = mng.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience p)
        {
            mng.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = mng.TGetByID(id);
            mng.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
