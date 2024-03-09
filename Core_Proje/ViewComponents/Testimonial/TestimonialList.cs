using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        private TestimonialManager manager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var value = manager.TGetList();
            return View(value);
        }
    }
}
