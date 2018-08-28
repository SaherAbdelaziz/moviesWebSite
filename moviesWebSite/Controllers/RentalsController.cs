using System.Web.Mvc;

namespace moviesWebSite.Controllers
{
    public class RentalsController : Controller
    {
        [Authorize]
        public ActionResult New()
        {
            return View();
        }
    }
}