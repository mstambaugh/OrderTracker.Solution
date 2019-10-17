using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace Orders.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }
        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/orders")]
        public ActionResult Create(string orderName, int OrderPrice)
        {
            Order myOrder = new Order(orderName);
            return RedirectToAction("Index");
        }
        [HttpGet("/orders/{id}")]
        public ActionResult Show(int id)
        {
            Order foundOrder = Order.Find(id);
            return View(foundOrder);
        }
    }
}