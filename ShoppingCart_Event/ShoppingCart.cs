using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ShoppingCart_Event
{    
    public class ShoppingCart
    {
       
        public List<Product> Products {get;set;}  

        // public delegate void ShoppingCartEventHandler(object sender, ShoppingCartEventArgs args);
        // public event ShoppingCartEventHandler ShoppingCartChanged;

        public event EventHandler<ShoppingCartEventArgs> ShoppingCartChanged;    

        public ShoppingCart()
        {
            Products = (new Product()).GetProducts();           
        }

        public void AddToCart(Product product)
        {
            Products.Add(product);    
            OnAdded(product);        
        }

        public void RemoveFromCart(Product product)
        {
            Products.Remove(product);
            OnRemoved(product);
        }

        public void ApplyDiscount()
        {            
            Console.WriteLine($"Discount applied");
            //var observableCollection = new ObservableCollection<Product>();            
            // observableCollection.CollectionChanged += ListChanged;
            IsProductEligible isProductEligible = ApplyDiscount;
            Discount.ApplyDiscount(Products, isProductEligible);
        }

        public bool ApplyDiscount(Product product)
        {
            return product.Category.Equals("DiscountCategory");
        }

        protected virtual void OnChange(Product product, string eventName)
        {
            if(ShoppingCartChanged != null)
            {
                ShoppingCartChanged(this, new ShoppingCartEventArgs(){ Product=product, EventName=eventName });
            }
        }
        protected virtual void OnAdded(Product product)
        {
            if(ShoppingCartChanged != null)
            {
                ShoppingCartChanged(this, new ShoppingCartEventArgs(){ Product=product, EventName="Added" });
            }
        }

        protected virtual void OnRemoved(Product product)
        {
            if(ShoppingCartChanged != null)
            {
                ShoppingCartChanged(this, new ShoppingCartEventArgs(){ Product=product, EventName="Removed" });
            }
        }
    }
}