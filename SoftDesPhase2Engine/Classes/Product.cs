using System;
using System.Collections.Generic;

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

