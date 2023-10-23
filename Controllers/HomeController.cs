using FIrstDEMOMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FIrstDEMOMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            ViewData["names"] = "This is the sample text in viewdata";
            List<string> names = new List<string>()
            {
                "Riya","Shruti","Aditya","Vivek","Kishor"
            };
            ViewData["list"]= names;
            return View();
        }

        public IActionResult AboutUs()
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