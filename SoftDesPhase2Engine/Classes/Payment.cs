using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public interface IPaymentProcessor
    {
        bool ProcessPayment(decimal amount, DateTime paymentDate, string paymentMethod);
    }

    public interface IRefundProcessor
    {
        bool RefundPayment(int paymentId);
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsSuccessful { get; set; }

        public Payment(int paymentId, decimal amount, DateTime paymentDate, string paymentMethod, bool isSuccessful)
        {
            PaymentId = paymentId;
            Amount = amount;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
            IsSuccessful = isSuccessful;
        }

        public string GetPaymentDetails()
        {
            string paymentDetails = $"Payment ID: {PaymentId}\nAmount: {Amount}\nPayment Date: {PaymentDate}\nPayment Method: {PaymentMethod}\nIs Successful: {IsSuccessful}";
            return paymentDetails;
        }
    }

    public class PaymentProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount, DateTime paymentDate, string paymentMethod)
        {
            // assumes the payment always succeeds
            return true;
        }
    }

    public class RefundProcessor : IRefundProcessor
    {
        public bool RefundPayment(int paymentId)
        {
            // assumes the refund always succeeds
            return true;
        }
    }
}

//Single Responsibility Principle: Each class/interface has a single responsibility, which makes it easy to maintain and test.
//Interface Segregation Principle: The interfaces define only the methods that are needed, which reduces coupling between classes.
//Dependency Inversion Principle: The PaymentProcessor and RefundProcessor classes depend on abstractions (IPaymentProcessor and IRefundProcessor),
//not on concrete implementations. This makes the code flexible and easy to extend.
