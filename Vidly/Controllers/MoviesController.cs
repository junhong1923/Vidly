using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

            // ViewModel
            var customers = new List<Customer> // object initialization syntax
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel // create ViewModel object and init properties
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //  GET: movies/edit?id=1 or movies/edit/1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies or override parameter with /movies?pageIndex=3&sortBy=Date
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            // 為了要讓 parameter optional，make it nullable
            // pageIndex: ? make it an nullable integer
            // sortBy: string in C# is a reference type, it's nullable
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")] // Attribute-based Routing
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}