using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialProject.Pages;

namespace TutorialProject.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Privacy Policy";

            return View("~/Pages/Privacy");
        }
    }
}
