using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskFirst.Models;

namespace TaskFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public ViewResult Index()
        {
            return View("MainPage");
        }
        [HttpPost]
        public ViewResult HelloUser(GetName getName)
        {
            Users.AddUser(getName);
            return View("HelloUser", getName);
        }
    }
}