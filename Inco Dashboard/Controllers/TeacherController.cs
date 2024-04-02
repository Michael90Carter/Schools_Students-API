using Microsoft.AspNetCore.Mvc;

namespace Inco_Dashboard.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
