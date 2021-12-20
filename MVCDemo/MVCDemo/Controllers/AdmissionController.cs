using Microsoft.AspNetCore.Mvc;
using MVCDemo.Attributes;
using MVCDemo.Models.Admission;

namespace MVCDemo.Controllers
{
    public class AdmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdmissionViewModel model)
        {
            if(ModelState.IsValid)
            {
                return Content("Form filled in successfully");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAjax]
        public IActionResult Submit(AdmissionViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Content("Form filled in successfully");
            }
            return Content("Validation failed");
        }
    }
}
