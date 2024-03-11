using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        private PortfolioManager mng = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var value = mng.TGetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator validator = new PortfolioValidator();

            ValidationResult result = validator.Validate(p);
            if (result.IsValid)
            {
                mng.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                        ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();

        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = mng.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            mng.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = mng.TGetByID(id);
            mng.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
