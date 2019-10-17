using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
