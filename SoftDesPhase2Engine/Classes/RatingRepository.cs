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
