using System;
using System.Collections.Generic;

namespace ShoppingCart_Solution
{    
    public class ShoppingCart
    {
        public void ApplyDiscount()
        {
            var products = (new Product()).GetProducts();
            IsProductEligible isProductEligible = ApplyDiscount;
            Discount.ApplyDiscount(products, isProductEligible);
        } 

        public bool ApplyDiscount(Product product)
        {
            return product.Category.Equals("DiscountCategory");
        }
    }
}