using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            Order firstOrder = new Order("Add first item to To Do List");
            return View(firstOrder);
        }

    }
}
