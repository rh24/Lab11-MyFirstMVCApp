using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab11_MyFirstMVCApp.Models;

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
        public IActionResult Index(int begYear, int endYear)
        {
            // Redirect to Result action within this controller
            return RedirectToAction("Result", new { begYear, endYear });
        }

        public ViewResult Result(int begYear, int endYear)
        {
            List<TimePerson> peopleOfTheYear = TimePerson.GetPersons(begYear, endYear);

            ViewData["begYear"] = begYear;
            ViewData["endYear"] = endYear;

            return View(peopleOfTheYear);
        }
    }
}
