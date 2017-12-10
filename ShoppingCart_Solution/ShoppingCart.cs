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
            // AnonymousDelegates(products);
            // LambdaExpressions(products);            
        } 

        public bool ApplyDiscount(Product product)
        {
            return product.Category.Equals("DiscountCategory");
        }

        public void AnonymousDelegates(IList<Product> products)
        {
            Discount.ApplyDiscount(products, delegate(Product p)
            {
                return p.Category.Equals("DiscountCategory");
            });
        }

        public void LambdaExpressions(IList<Product> products)
        {
            Discount.ApplyDiscount(products, (p) => 
            {
                return p.Category.Equals("DiscountCategory");
            });
        }
    }
}