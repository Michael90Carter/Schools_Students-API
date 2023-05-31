using Microsoft.AspNetCore.Mvc;

namespace Inco_Dashboard.Controllers
{
    public class ClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
