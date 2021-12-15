using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
