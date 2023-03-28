// This code defines a class called "Farmer" that represents a farmer in the e-commerce system.
// It contains properties for name, contact information, farm location, farm description, and a list of products.
// The class implements the IFarmerOrderManager and IFarmerEarningsCalculator interfaces.
// The IFarmerOrderManager interface defines a method for retrieving orders for a farmer.
// The IFarmerEarningsCalculator interface defines a method for calculating the total earnings for a farmer.
// The class also has methods for adding, removing, and updating products.

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
            // Initialize the properties
            Name = name;
            ContactInfo = contactInfo;
            FarmLocation = farmLocation;
            FarmDescription = farmDescription;
            Products = new List<Product>(); // Create an empty list of products
        }

        // Methods
        public void AddProduct(Product product)
        {
            Products.Add(product); // Add a new product to the list of products
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product); // Remove a product from the list of products
        }

        public void UpdateProduct(Product product)
        {
            int index = Products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                Products[index] = product; // Update a product in the list of products
            }
        }

        public List<Order> GetOrders(Farmer farmer)
        {
            // code to retrieve orders for this farmer
            return null; // Placeholder return statement
        }

        public double CalculateEarnings(Farmer farmer, List<Order> orders)
        {
            double totalSales = 0;
            foreach (var product in Products)
            {
                totalSales = product.GetTotalSales(orders); // Calculate the total sales for each product
            }
            return totalSales; // Return the total earnings for the farmer
        }
    }

}

// This code follows the Single Responsibility Principle by separating the farmer class from other classes in the system, and each method of the class performs a single task.
// The Open/Closed Principle is also followed since the code is designed to be easily extended in the future without the need for modifying the existing code.
// Additionally, the code follows the Dependency Inversion Principle since it only depends on the abstractions of the IFarmerOrderManager and IFarmerEarningsCalculator interfaces
// and does not depend on the implementation details of them.