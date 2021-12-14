using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System;
using System.Linq;

namespace MVCDemo.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Country"] = "India";
            ViewData["Phrase"] = "HOnesty is the best policy";

            ViewBag.FirstName = "Anurag";
            ViewBag.LastName = "Sinha";

            return View();
        }


        public IActionResult Details()
        {
            var model = new PersonViewModel
            {
                Id=101,
                Name="John",
                Occupation="Fireman"
            };

            return View(model);
        }

        public IActionResult Demo()
        {
            ViewData["City"] = "Delhi";
            ViewData["Country"] = "India";
            ViewData["Continent"] = "Asia";

            Console.WriteLine(ViewData.Keys);

            var model = new DemoViewModel
            {
                ViewDataCount=ViewData.Count,
                ViewDataKeys=ViewData.Keys.ToList(),
                ViewDataValues=ViewData.Values.ToList()
            };

            return View(model);
        }
    }
}
