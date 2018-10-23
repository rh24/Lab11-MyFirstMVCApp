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
        /// <summary>
        /// This action gets the Home/Index view and shows it to the user.
        /// </summary>
        /// <returns>ViewResult object</returns>
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        /// <summary>
        /// This action is a POST request that redirects the user to the Result action within this same Home Controller. The two paramaters of data that are sent over are the user input years. This data was sent from the form submit within the Home/Index view.
        /// </summary>
        /// <param name="begYear">start year user input</param>
        /// <param name="endYear">end year user input</param>
        /// <returns>Object that implements the IActionResult interface</returns>
        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            // Redirect to Result action within this controller
            return RedirectToAction("Result", new { begYear, endYear });
        }

        /// <summary>
        /// This controller action displays the Views/Home/Result page and passes 3 pieces of data to the view: the searched beginning year, end year, a List of TimePerson objects.
        /// </summary>
        /// <param name="begYear">start year user inputs</param>
        /// <param name="endYear">end year user inputs</param>
        /// <returns>ViewResult object with collection of TimePerson objects</returns>
        public ViewResult Result(int begYear, int endYear)
        {
            List<TimePerson> peopleOfTheYear = TimePerson.GetPersons(begYear, endYear);

            ViewData["begYear"] = begYear;
            ViewData["endYear"] = endYear;

            return View(peopleOfTheYear);
        }
    }
}
