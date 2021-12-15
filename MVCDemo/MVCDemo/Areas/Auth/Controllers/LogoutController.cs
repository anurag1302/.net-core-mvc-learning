using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
