using System.Collections.Generic;
using System.Linq;

namespace SoftDesPhase2Engine.Classes
{

    public interface IFarmerOrderManager
    {
        List<Order> GetOrders(Farmer farmer);
    }

    public interface IFarmerEarningsCalculator
    {
        double CalculateEarnings(Farmer farmer, List<Order> orders);
    }


    public class Farmer : IFarmerOrderManager, IFarmerEarningsCalculator
    {
        // Properties
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string FarmLocation { get; set; }
        public string FarmDescription { get; set; }
        public List<Product> Products { get; set; }

        // Constructor
        public Farmer(string name, string contactInfo, string farmLocation, string farmDescription)
        {
            Name = name;
            ContactInfo = contactInfo;
            FarmLocation = farmLocation;
            FarmDescription = farmDescription;
            Products = new List<Product>();
        }

        // Methods
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            int index = Products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                Products[index] = product;
            }
        }

        public List<Order> GetOrders(Farmer farmer)
        {
            // code to retrieve orders for this farmer
            return null;
        }

        public double CalculateEarnings(Farmer farmer, List<Order> orders)
        {
            double totalSales = 0;
            foreach (var product in Products)
            {
                totalSales = product.GetTotalSales(orders);
            }
            return totalSales;
        }
    }
}
