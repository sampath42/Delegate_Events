using System;
using System.Collections.Generic;

namespace Demo{
    public class Product
    {        
        public string Name{get;set;}
        public string Category{get;set;}
        public double Amount{get;set;}             
    }

    public class ShoppingCart
    {
        public static void ApplyDiscount(List<Product> products, IsProductEligible isProductEligible)
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