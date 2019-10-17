using System.Collections.Generic;

namespace OrderTracker.Models
{
    public class Order
    {
        public string OrderName { get; set; }

        public int OrderPrice { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string orderItem, int orderPrice)
        {
            OrderName = orderItem;
            _instances.Add(this);
            OrderPrice = orderPrice
            Id = _instances.Count;

        }
        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}