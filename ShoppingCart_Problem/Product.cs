using System.Collections.Generic;

namespace ShoppingCart_Problem
{
    public class Product
    {
        public string Name{get;set;}
        public string Category{get;set;}
        public double Amount{get;set;}

        public List<Product> GetProducts()
        {
            Product tShirt=new Product()
            {
                Name="Buffalo Brand Red T-Shirt", 
                Amount=2000.00,
                Category="DiscountCategory"
            };
            Product formalShoes=new Product()
            {
                Name="XYZ Brand Black Formal Shoes size 8",
                Amount=1200.00,
                Category="ShoesCategory"
            };
            Product jeans=new Product()
            {
                Name="Buffalo Brand Blue Jeans XL", 
                Amount=2500.00,
                Category="DiscountCategory"
            };
            List<Product> products = new List<Product>()
            {
                tShirt,
                jeans,
                formalShoes
            };   
            return products;
        }
    }
}