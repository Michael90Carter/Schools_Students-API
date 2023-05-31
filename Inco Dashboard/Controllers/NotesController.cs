using Microsoft.AspNetCore.Mvc;

namespace Inco_Dashboard.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
