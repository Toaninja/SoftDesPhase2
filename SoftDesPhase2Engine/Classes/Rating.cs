using System;
using System.Collections.Generic;
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

        public float GetAverageRating()
        {
            return _repository.GetAverageRating(Product);
        }
    }
}
