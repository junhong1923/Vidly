using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //return View(movie); // put the movie model in the view so it can render it
            //return Content("Return plain string content in the response.");
            //return HttpNotFound();
            //return new EmptyResult();
            
            // use anonymous object to pass arg to the target action, arg will appear as query string
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
    }
}