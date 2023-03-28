using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShippingAddress { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, string email, string shippingAddress)
        {
            Id = id;
            Name = name;
            Email = email;
            ShippingAddress = shippingAddress;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void CancelOrder(Order order)
        {
            Orders.Remove(order);
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public bool HasOrder(Order order)
        {
            return Orders.Contains(order);
        }
    }
}

