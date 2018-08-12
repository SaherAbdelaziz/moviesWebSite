using System.Collections.Generic;

namespace moviesWebSite.Controllers.API
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MoviesIds { get; set; }
    }
}