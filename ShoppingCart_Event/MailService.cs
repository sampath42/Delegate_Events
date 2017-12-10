using System;

namespace ShoppingCart_Event
{
    public class MailService
    {
        public void OnChanged(object sender, ShoppingCartEventArgs args)   
        {                
            var shoppingCart = (ShoppingCart)sender;
            Console.WriteLine($"Product {args.Product.Name} {args.EventName} in your shopping cart list below");
            foreach(Product product in shoppingCart.Products)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine($"Sending mail...");
        }
    }
}