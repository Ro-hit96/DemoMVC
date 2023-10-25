using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMVC.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune","Mumbai","Nashik","Sangli","Satara","Solapur"
            };


            ViewData["cities"] = new SelectList(cities);

            return View();
        }
    }
}
