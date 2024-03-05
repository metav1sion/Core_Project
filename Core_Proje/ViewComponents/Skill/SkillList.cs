using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        private SkillManager skill = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skill.TGetList();
            return View(values);
        }
    }
}
