using BusinessLayer.Concrete;
using Core_Proje.ViewComponents.Skill;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        private SkillManager manager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = manager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            manager.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var value = manager.TGetByID(id);
            manager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = manager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill p)
        {
            manager.TUpdate(p);
            return RedirectToAction("Index");
        }


    }
}
