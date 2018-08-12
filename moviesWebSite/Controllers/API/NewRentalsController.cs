using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using moviesWebSite.Models;

namespace moviesWebSite.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        ApplicationDbContext _context = new ApplicationDbContext();


        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.MoviesIds.Count == 0)
            {
                return BadRequest("No Movie Ids have been given.");
            }

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            if (customer == null)
            {
                return BadRequest("CusomerId is not valid.");
            }
            
            
            var movies = _context.Movies.Where
                (m => newRental.MoviesIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MoviesIds.Count)
            {
                return BadRequest("One or more MovieIds are invalid.");
            }

                foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }
                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };


                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }
    }
}