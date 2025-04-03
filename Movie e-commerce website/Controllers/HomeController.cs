using Microsoft.AspNetCore.Mvc;
using Movie_e_commerce_website.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace Movie_e_commerce_website.Controllers
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
        var n=new List<string>();
        n.Add("okay");
         n.Add("yeah");
          n.Add("today");
            return View(n);
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
    }
}
