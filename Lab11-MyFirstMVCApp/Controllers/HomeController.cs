using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            // Redirect to Result action within this controller
            return RedirectToAction("Result", new { startYear, endYear });
        }

        public ViewResult Result(int startYear, int endYear)
        {

            return View();
        }
    }
}
