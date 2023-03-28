using System;
using System.Collections.Generic;
using SoftDesPhase2Engine.Classes.SoftDesPhase2Engine.Classes;
using SoftDesPhase2Engine.Classes;
using SoftDesPhase2Engine.Classes.SoftDesPhase2Engine.Repositories;

namespace SoftDesPhase2Engine.Classes
{
    public class Ratings
    {
        private readonly RatingRepository _repository;

        // Properties
        public int Id { get; set; }
        public int RatingValue { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }

        // Constructor
        public Ratings(RatingRepository repository, int id, int rating, string comment, DateTime date, Customer customer, Product product)
        {
            _repository = repository;
            Id = id;
            RatingValue = rating;
            Comment = comment;
            Date = date;
            Customer = customer;
            Product = product;
        }

        // Methods
        public void AddRating()
        {
            _repository.AddRating(this);
        }

        public void UpdateRating()
        {
            _repository.UpdateRating(this);
        }

        public void DeleteRating()
        {
            _repository.DeleteRating(Id);
        }

        public List<Ratings> GetRatingsByProduct()
        {
            return _repository.GetRatingsByProduct(Product);
        }

        public List<Ratings> GetRatingsByCustomer()
        {
            return _repository.GetRatingsByCustomer(Customer);
        }

        public double GetAverageRating(Product product)
        {
            return _repository.GetAverageRating(product);
        }
    }
}

//Single Responsibility Principle (SRP) as the Ratings class is responsible for handling ratings-related functionality only.The implementation of the rating repository is separated into a
//separate class, RatingRepository, which follows the SRP as well.

//The Ratings class also uses the Dependency Inversion Principle (DIP) by taking an instance of RatingRepository through its constructor instead of creating the repository itself.
//This allows for better maintainability and extensibility by enabling the use of different implementations of RatingRepository in the future without modifying the Ratings class.

//The class also follows the Liskov Substitution Principle (LSP) as it conforms to the IRateable interface, which defines a GetAverageRating() method.Ratings implements the GetAverageRating()
//method by calling the GetAverageRating() method of its RatingRepository instance.