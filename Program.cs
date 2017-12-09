using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using ShoppingCart_Problem;
using ShoppingCart_Solution;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           //SimpleDelegateSample();
           //MulticastDelegate_Sample();
           //ShoppingCart_Example();
        }     

        static void ShoppingCart_Example()
        {
            ShoppingCart_Problem.ShoppingCart shoppingCart = new ShoppingCart_Problem.ShoppingCart();
            //ShoppingCart_Solution.ShoppingCart shoppingCart = new ShoppingCart_Solution.ShoppingCart();
            shoppingCart.ApplyDiscount();
        }    

        static void SimpleDelegate_Sample()
        {
            SimpleDelegateSample simpleDelegateSample = new SimpleDelegateSample();
            simpleDelegateSample.TransformTest();            
        }

        static void MulticastDelegate_Sample()
        {
            MulticastDelegate_Sample multicastDelegate = new MulticastDelegate_Sample();
            multicastDelegate.Run();
        }
    }       
}
