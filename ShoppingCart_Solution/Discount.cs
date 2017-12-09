using System;
using System.Collections.Generic;

namespace ShoppingCart_Solution
{
    public delegate bool IsProductEligible(Product p);
    public class Discount
    {
        public static void ApplyDiscount(IList<Product> products, IsProductEligible isProductEligible)
        {
            foreach(Product product in products)
            {
                if(isProductEligible(product))
                {
                    Console.WriteLine($"Discount Applied to {product.Name}");
                }
            }
        }
    }
}