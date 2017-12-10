using System;

namespace ShoppingCart_Event
{
    public class ShoppingCartEventArgs:EventArgs
    {
        public Product Product{get;set;}

        public String EventName{get;set;}
    }
}