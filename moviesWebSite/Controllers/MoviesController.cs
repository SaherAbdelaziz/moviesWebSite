using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using moviesWebSite.Models;

namespace moviesWebSite.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
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

        /*
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;

            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex = {0} & sortBy = {1} ", pageIndex, sortBy));
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "sherk!", Id = 1};
            var Customers = new List<Customer>()
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"} ,
                new Customer {Name = "Customer 3"},
                new Customer {Name = "Customer 4"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers
            };

            
            return View(viewModel);

            //return Content("HI");
            //return HttpNotFound();
        }
        

        [Route("movies/released/{year:regex(\\d{4})}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year + "/" + month);
        }
        */
    }
}