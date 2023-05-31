using Inco_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Inco_Dashboard.Controllers
{
    public class AddmarksController : Controller
    {
        private readonly ILogger<AddmarksController> _logger;
    
        public AddmarksController(ILogger<AddmarksController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
