using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        private ToDoListManager _manager = new ToDoListManager(new EfToDoListDal());

        public IViewComponentResult Invoke()
        {
            var values = _manager.TGetList();
            return View(values);
        }
    }
}
