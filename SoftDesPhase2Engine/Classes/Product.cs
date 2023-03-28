using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace SoftDesPhase2Engine.Classes
{
    public interface IRateable
    {
        void AddRating(Ratings rating);
        double GetAverageRating();
    }

    public interface IQuantifiable
    {
        bool IsAvailable();
        void DecreaseQuantity(int amount);
    }

    public interface ISellable
    {
        double GetTotalSales(List<Order> orders);
    }

    public class Product : IRateable, IQuantifiable, ISellable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Farmer Seller { get; set; }
        public List<Ratings> Ratings { get; set; }

        public Product(int id, string name, string description, double price, int quantity, Farmer seller)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Seller = seller;
            Ratings = new List<Ratings>();
        }

        public void AddRating(Ratings rating)
        {
            Ratings.Add(rating);
        }

        public double GetAverageRating()
        {
            if (Ratings.Count == 0)
            {
                return 0;
            }

            double totalRating = 0;

            foreach (var rating in Ratings)
            {
                totalRating += rating.RatingValue;
            }

            return totalRating / Ratings.Count;
        }

        public bool IsAvailable()
        {
            return Quantity > 0;
        }

        public void DecreaseQuantity(int amount)
        {
            if (amount > Quantity)
            {
                throw new Exception("Not enough quantity available.");
            }
            Quantity -= amount;
        }

        public double GetTotalSales(List<Order> orders)
        {
            double totalSales = 0;
            foreach (var order in orders)
            {
                foreach (var orderItem in order.OrderItems)
                {
                    if (orderItem.Product.Id == this.Id)
                    {
                        totalSales += (double)(orderItem.Product.Price * orderItem.Quantity);
                    }
                }
            }
            return totalSales;
        }
    }
}

//Single Responsibility Principle (SRP): The Product class has only one responsibility, which is to represent a product and provide functionality related to it, such as adding a rating,
//checking availability, decreasing the quantity, and getting the total sales. Each interface also has a single responsibility related to a product, such as rating, quantity, and sales.

//Open / Closed Principle(OCP): The Product class is open for extension but closed for modification, which means that new functionality can be added to the class without changing its existing
//implementation. For example, new interfaces can be added to the class without modifying its existing methods, which makes the code more flexible and easier to maintain.

//Liskov Substitution Principle (LSP): The Product class implements the IRateable, IQuantifiable, and ISellable interfaces, and any instance of the Product class can be used wherever any of
//these interfaces are expected. This means that the Product class satisfies the LSP.

//Interface Segregation Principle (ISP): The interfaces (IRateable, IQuantifiable, and ISellable) are designed to be segregated and only contain the methods that are relevant to their respective
//responsibilities. This makes the interfaces more focused and less likely to be changed, and allows for classes to implement only the interfaces they need.

//Dependency Inversion Principle (DIP): The interfaces (IRateable, IQuantifiable, and ISellable) are defined separately from the Product class, which makes the class less dependent on specific
//implementations of those interfaces. This makes the code more flexible, since different implementations of those interfaces can be used without changing the Product class.