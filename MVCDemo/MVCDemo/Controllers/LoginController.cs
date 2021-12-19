using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models.Login;

namespace MVCDemo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Email == "anurag@gmail.com" && model.Password == "test")
            {
                ViewBag.Success = "Your login is successful !!!";
            }
            else
            {
                ModelState.AddModelError("Password", "Invalid Login attempt.");
            }
            return View();
        }
    }
}
