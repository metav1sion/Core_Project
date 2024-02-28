using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        private ServiceManager service = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = service.TGetList();
            return View(values);
        }
    }
}
