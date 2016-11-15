using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MatchingGame.Controllers
{
    [Authorize]
    [RequireHttps]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult GameSelector()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult GameScreen()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
