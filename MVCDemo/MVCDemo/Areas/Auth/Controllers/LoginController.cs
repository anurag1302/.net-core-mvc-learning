using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
