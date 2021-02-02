using Projekt1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt1.Interface
{
    public interface IReviewRepository
    {
        Review Get(int reviewId);
        IEnumerable<Review> GetAll();
        Review Post(Review newReview);
        Review Put(Review updatedReview);
        Review Delete(int reviewId);
    }

}
