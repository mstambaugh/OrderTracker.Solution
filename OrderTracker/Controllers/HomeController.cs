using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }
        [HttpPost("/items")]
        public ActionResult Create(string orderItem)
        {
            Order myItem = new Order(orderItem);
            return RedirectToAction("Index");
        }
    }
}
