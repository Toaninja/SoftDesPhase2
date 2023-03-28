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
        void ProcessPayment(Payment payment);
        void RefundPayment();
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

        /**
        public void ProcessPayment(Payment payment)
        {
            Payment = payment;
            IsPaid = payment.ProcessPayment();
        }

        public void RefundPayment()
        {
            if (Payment != null)
            {
                Payment.RefundPayment();
                IsPaid = false;
            }
        }
        */

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
