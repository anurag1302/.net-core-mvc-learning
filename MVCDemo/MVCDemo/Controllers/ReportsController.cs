using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Collections.Generic;

namespace MVCDemo.Controllers
{
    public class ReportsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult JQueryPost()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string name, string city, string gender, string number)
        //{
        //    return Content($"{name}{"--"}{city}{"--"}{gender}{"--"}{number}");
        //}

        //[HttpPost]
        //public IActionResult Index(IFormCollection form)
        //{
        //    var name = form["Name"].ToString();
        //    var city = form["City"].ToString();
        //    var gender = form["Gender"].ToString();
        //    var number = form["Number"].ToString();

        //    return Content($"{name}{"--"}{city}{"--"}{gender}{"--"}{number}");
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RegistrationViewModel model)
        {
            return Content($"{model.Name}{"--"}{model.City}{"--"}{model.Gender}{"--"}{model.Number}");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult JQueryPost(RegistrationViewModel model)
        {
            return Content($"{model.Name}{"--"}{model.City}{"--"}{model.Gender}{"--"}{model.Number}");
        }

        public IActionResult Person()
        {
            var persons = Data.GetPersons();

            return View(persons);
        }
    }
}
