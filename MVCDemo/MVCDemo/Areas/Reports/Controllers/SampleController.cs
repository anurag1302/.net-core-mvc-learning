using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Areas.Reports.Controllers
{
    [Area("Reports")]
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
