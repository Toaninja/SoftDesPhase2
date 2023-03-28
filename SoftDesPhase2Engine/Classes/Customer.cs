// This code defines a class called "Customer" that represents a customer in the e-commerce system.
// It contains properties for customer ID, name, email, and shipping address, as well as a list of orders.
// The class also has methods for adding and canceling orders, getting a list of orders, and checking if the customer has a specific order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public class Customer
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShippingAddress { get; set; }
        public List<Order> Orders { get; set; }

        // Constructor
        public Customer(int id, string name, string email, string shippingAddress)
        {
            // Initialize the properties
            Id = id;
            Name = name;
            Email = email;
            ShippingAddress = shippingAddress;
            Orders = new List<Order>(); // Create an empty list of orders
        }

        // Methods
        public void AddOrder(Order order)
        {
            Orders.Add(order); // Add a new order to the list of orders
        }

        public void CancelOrder(Order order)
        {
            Orders.Remove(order); // Remove an order from the list of orders
        }

        public List<Order> GetOrders()
        {
            return Orders; // Return a list of all orders for this customer
        }

        public bool HasOrder(Order order)
        {
            return Orders.Contains(order); // Check if the customer has a specific order
        }
    }
}

// This code follows the Single Responsibility Principle by separating the customer class from other classes in the system, and each method of the class performs a single task.
// The Open/Closed Principle is also followed since the code is designed to be easily extended in the future without the need for modifying the existing code.
// Additionally, the code follows the Dependency Inversion Principle since it only depends on the abstraction of the Order class and does not depend on the implementation details of it.
