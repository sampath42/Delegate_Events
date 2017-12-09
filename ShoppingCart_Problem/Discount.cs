using System;
using System.Collections.Generic;

namespace ShoppingCart_Problem
{
    public class Discount
    {
        public static void ApplyDiscount(List<Product> products)
        {
            foreach(Product product in products)
            {
                if(product.Category.Equals("DiscountCategory"))
                {
                    Console.WriteLine($"Discount Applied to {product.Name}");
                }
            }
        } 
    }
}