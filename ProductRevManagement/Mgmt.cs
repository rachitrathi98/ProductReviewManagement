using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductRevManagement
{
    public class Mgmt
    {   
        public readonly DataTable table = new DataTable();
        /// <summary>
        /// Retrieves the top three records.
        /// </summary>
        /// <param name="reviews">The reviews.</param>
        public static void RetrieveTop(List<ProductReview> reviews)
        {
            var list = (from products in reviews orderby products.Ratings descending select products).Take(3).ToList();

            foreach (var review in list)
            {
                Console.WriteLine("ProductID: " + review.ProductID + ", UserID: " + review.UserID + ", Ratings: " + review.Ratings + " , Review: " + review.Review + " , IsLike: " + review.IsLike);
            }
        }
        /// <summary>
        /// Retrieve rating > 3 and product ID 1,4 or 9
        /// </summary>
        /// <param name="reviews">The reviews.</param>
        public static void RetrieveonCond(List<ProductReview> reviews)
        {
            var list = (from products in reviews where products.Ratings > 3 && (products.ProductID == 1 || products.ProductID == 4 || products.ProductID == 9) select products);

            foreach (ProductReview product in list)
            {
                Console.WriteLine("ProductID: " + product.ProductID + ", UserID: " + product.UserID + ", Ratings: " + product.Ratings + " , Review: " + product.Review + " , IsLike: " + product.IsLike);
            }

        }
    }
}
