﻿
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

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
			var movie = new Movie() { Name = "Shrek!"};

            var customers = new List<Customer> {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel() {
                Movie = movie,
                Customers = customers


            };
            /*
             * ViewData["Movie"] = movie;
             * 
             * 
             * 
             * */

            //	return View(movie);
            //return Content("hello world.");
            // return HttpNotFound();
            // return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy= "Name" });

            return View(viewModel);
        }

        // constraints for month
      //  [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id) {
			return Content("id = " + id);
		}
    }
}

