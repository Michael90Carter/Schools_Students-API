using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inco_Dashboard.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
