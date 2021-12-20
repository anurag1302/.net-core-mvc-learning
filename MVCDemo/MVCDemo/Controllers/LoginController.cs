using Microsoft.AspNetCore.Mvc;
using MVCDemo.Attributes;
using MVCDemo.Models.Login;
using System.Collections.Generic;

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

        [HttpPost]
        [ValidateAjax]
        public IActionResult Submit(LoginViewModel model)
        {
            if (model.Email == "anurag@gmail.com" && model.Password == "test")
            {
                return new JsonResult(new { message= "Your login is successful!!!" });
            }
            else
            {
                var errors = new List<ErrorMessage>
                {
                    new ErrorMessage
                    {
                        Key = "Password",
                        Errors = new string[] { "Invalid Login Attempt!!!", "please try again !!!" }
                    }
                };

                var json = new JsonResult(errors)
                {
                    StatusCode = 400
                };
                return json;
            }
            
        }

        public class ErrorMessage
        {
            public string Key { get; set; }
            public string[] Errors { get; set; }
        }
    }
}
