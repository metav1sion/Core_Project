using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        private Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x=>x.Status == false).Count();
            ViewBag.v3 = c.Messages.Where(x=>x.Status == true).Count();
            ViewBag.v = c.Experiences.Count();
            return View();
        }
    }
}
