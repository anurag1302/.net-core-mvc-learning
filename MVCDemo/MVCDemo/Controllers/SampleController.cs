using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

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
    }
}
