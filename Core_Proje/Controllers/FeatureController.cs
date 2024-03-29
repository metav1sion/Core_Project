﻿using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        private FeatureManager mng = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = mng.TGetByID(2);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature p)
        {
            mng.TUpdate(p);
            return RedirectToAction("Index","Default");
        }
    }
}
