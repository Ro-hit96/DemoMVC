using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoMVC.Controllers
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
            ViewData["message"] = "This is sample text in Viewdata";
            List<string> names = new List<string>()
            {
                "Akashay","Amol","Tushar","Vivek",
            };
            ViewData["list"] = names;//implicit -->Object
                                     ////////////////////////////////////////////////////////////////////////////////////
            /*ViewData["message"] = "This is sample Cities in Viewdata";
            List<string> city = new List<string>()
            {
                "pune","Mumbai","ENGland","AustS",
            };
            ViewData["list"] = city;*/

            //Working With ViewBag
            ViewBag.Year = 2023;
            ViewBag.Month = "Oct";
            ViewBag.Names= names;

            TempData["company"] = "Think Quotient";
            TempData.Keep("Compant");
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult ContactUS()
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