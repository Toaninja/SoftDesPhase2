using SoftDesPhase2Engine.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    using global::SoftDesPhase2Engine.Classes.SoftDesPhase2Engine.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace SoftDesPhase2Engine.Repositories
    {
        public class RatingRepository
        {
            private readonly List<Ratings> _ratings;

            public RatingRepository()
            {
                _ratings = new List<Ratings>();
            }

            public void AddRating(Ratings rating)
            {
                _ratings.Add(rating);
            }

            public void UpdateRating(Ratings rating)
            {
                var existingRating = _ratings.FirstOrDefault(r => r.Id == rating.Id);
                if (existingRating != null)
                {
                    existingRating.RatingValue = rating.RatingValue;
                    existingRating.Comment = rating.Comment;
                    existingRating.Date = rating.Date;
                    existingRating.Customer = rating.Customer;
                    existingRating.Product = rating.Product;
                }
            }

            public void DeleteRating(int ratingId)
            {
                var ratingToRemove = _ratings.FirstOrDefault(r => r.Id == ratingId);
                if (ratingToRemove != null)
                {
                    _ratings.Remove(ratingToRemove);
                }
            }

            public List<Ratings> GetRatingsByProduct(Product product)
            {
                return _ratings.Where(r => r.Product.Id == product.Id).ToList();
            }

            public List<Ratings> GetRatingsByCustomer(Customer customer)
            {
                return _ratings.Where(r => r.Customer.Id == customer.Id).ToList();
            }

            public double GetAverageRating(Product product)
            {
                var productRatings = _ratings.Where(r => r.Product.Id == product.Id);
                if (productRatings.Any())
                {
                    return productRatings.Average(r => r.RatingValue);
                }
                else
                {
                    return 0;
                }
            }
        }
    }

}


//Single Responsibility Principle (SRP): The RatingRepository class has a single responsibility of managing ratings data and provides methods to add, update, delete, and retrieve rating objects.

//Open-Closed Principle (OCP): The RatingRepository class is open for extension but closed for modification.This is because if we want to add new functionalities to this class, we can do so
//without changing the existing code.

//Liskov Substitution Principle (LSP): The RatingRepository class uses List<Ratings> to store ratings, which means that any subtype of Ratings can be used interchangeably with the
//RatingRepository class.

//Interface Segregation Principle (ISP): There are no interfaces explicitly defined in this code, but the design follows the principle by not including any unnecessary methods in the
//RatingRepository class.

//Dependency Inversion Principle (DIP): The RatingRepository class depends on abstractions rather than concrete implementations. For example, the AddRating method accepts a Ratings object as a
//parameter rather than a specific type of Ratings object. This allows for greater flexibility and makes the code easier to maintain and test.