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

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(m => newRental.MoviesIds.Contains(m.Id));

            foreach (var movie in movies)
            {
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