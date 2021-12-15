using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new PersonViewModel
            {
                Id = 101,
                Name = "JOhn",
                Occupation = "Fireman"
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            var model = new PersonViewModel
            {
                Id = 102,
                Name = "Mary",
                Occupation = "Astronaut"
            };
            return View(model);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult GetEmployeeDetails()
        {
            var model = new PersonViewModel
            {
                Id = 103,
                Name = "Neeraj Chopra",
                Occupation = "Javelin Thrower"
            };
            return PartialView("~/Views/Partials/_EmployeeDetailsPartial.cshtml",model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
