using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
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
        
    }
}
