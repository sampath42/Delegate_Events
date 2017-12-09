namespace ShoppingCart_Problem
{
    public class ShoppingCart
    {
        public void ApplyDiscount()
        {
            var products = (new Product()).GetProducts();
            Discount.ApplyDiscount(products);
        }
    }
}