using System;
using System.Collections.Generic;

namespace ProductRevManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management!");
            ///Create Product List
            List<ProductReview> reviews = new List<ProductReview>()
            {
                new ProductReview(){ ProductID = 1, UserID = 1, Ratings = 8, Review = "Good", IsLike = true},
                new ProductReview(){ ProductID = 2, UserID = 2, Ratings = 7, Review = "Good", IsLike = true},
                new ProductReview(){ ProductID = 3, UserID = 3, Ratings = 5, Review = "Good", IsLike = true},
                new ProductReview(){ ProductID = 20, UserID = 4, Ratings = 10, Review = "Good", IsLike = true},
                new ProductReview(){ ProductID = 23, UserID = 5, Ratings = 6, Review = "Nice", IsLike = false},
                new ProductReview(){ ProductID = 6, UserID = 6, Ratings = 3, Review = "Nice", IsLike = false},
                new ProductReview(){ ProductID = 20, UserID = 7, Ratings = 2, Review = "Bad", IsLike = false},
                new ProductReview(){ ProductID = 8, UserID = 8, Ratings = 1, Review = "Bad", IsLike = false},
                new ProductReview(){ ProductID = 20, UserID = 20, Ratings = 9, Review = "Good", IsLike = true},
                new ProductReview(){ ProductID = 21, UserID = 21, Ratings = 3, Review = "Nice", IsLike = false},
                new ProductReview(){ ProductID = 23, UserID = 23, Ratings = 4, Review = "Good", IsLike = true}
            };

            foreach (ProductReview review in reviews)
            {
                Console.WriteLine("ProductID: " + review.ProductID + ", UserID: " + review.UserID + ", Ratings: " + review.Ratings + " , Review: " + review.Review + " , IsLike: " + review.IsLike);
            }
            ///Retrieve top three records
            Mgmt.RetrieveTop(reviews);
            //Retrieve on Some Condition
            Mgmt.RetrieveonCond(reviews);
        }
    }
}
