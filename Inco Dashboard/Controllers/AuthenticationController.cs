using Microsoft.AspNetCore.Mvc;

namespace Inco_Dashboard.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Passwordreset()
        {
            return View();
        }
    }
}
