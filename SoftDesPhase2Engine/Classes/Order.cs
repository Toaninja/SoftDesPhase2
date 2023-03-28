// This code defines two interfaces, IOrderItem and IOrder, and two classes, OrderItem and Order, that implement these interfaces.
// The IOrderItem interface defines two properties, Product and Quantity, which represent the product being ordered and the quantity of the product.
// The IOrder interface defines several properties, including OrderId, OrderDate, Customer, OrderItems, Payment, and IsPaid, as well as two methods, GetTotalPrice and GetOrderDetails.
// The OrderItem class implements the IOrderItem interface and provides a constructor that takes a product and a quantity and initializes the properties.
// The Order class implements the IOrder interface and provides a constructor that takes a customer and a list of order items and initializes the properties.
// The class also has methods for calculating the total price of the order and getting the order details, which include the order ID, order date, customer name, order items, total price,
// payment method, and whether the order is paid or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public interface IOrderItem
    {
        Product Product { get; set; }
        int Quantity { get; set; }
    }

    public interface IOrder
    {
        int OrderId { get; set; }
        DateTime OrderDate { get; set; }
        Customer Customer { get; set; }
        List<IOrderItem> OrderItems { get; set; }
        Payment Payment { get; set; }
        bool IsPaid { get; set; }

        double GetTotalPrice();
        string GetOrderDetails();
    }

    public class OrderItem : IOrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }

    public class Order : IOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<IOrderItem> OrderItems { get; set; }
        public Payment Payment { get; set; }
        public bool IsPaid { get; set; }

        public Order(Customer customer, List<IOrderItem> orderItems)
        {
            OrderDate = DateTime.Now;
            Customer = customer;
            OrderItems = orderItems;
            IsPaid = false;
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var orderItem in OrderItems)
            {
                total += orderItem.Product.Price * orderItem.Quantity;
            }
            return total;
        }

        public string GetOrderDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order ID: {OrderId}");
            sb.AppendLine($"Order Date: {OrderDate}");
            sb.AppendLine($"Customer Name: {Customer.Name}");
            sb.AppendLine("Order Items:");
            foreach (var orderItem in OrderItems)
            {
                sb.AppendLine($"- {orderItem.Product.Name} x {orderItem.Quantity}: {orderItem.Product.Price * orderItem.Quantity}");
            }
            sb.AppendLine($"Total Price: {GetTotalPrice()}");
            sb.AppendLine($"Payment Method: {Payment?.PaymentMethod ?? "N/A"}");
            sb.AppendLine($"Is Paid: {IsPaid}");
            return sb.ToString();
        }
    }

}

// This code follows the Interface Segregation Principle since the interfaces are separated and each interface only contains a set of related properties or methods.
// Additionally, the code follows the Open/Closed Principle since the code is designed to be easily extended in the future without the need for modifying the existing code.
// Moreover, the code follows the Single Responsibility Principle by separating the order-related classes from other classes in the system, and each method of the class performs a single task.