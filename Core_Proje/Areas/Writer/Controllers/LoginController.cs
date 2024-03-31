using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                    //return Redirect("/Writer/Default/Index");
                    //return RedirectToAction("Index", "Default", new { area = "Writer" });

                }
                else
                {
                    ModelState.AddModelError("","Hatalı Kullanıcı Adı Veya Şifre");
                }
            }
            return View();
        }
    }
}
