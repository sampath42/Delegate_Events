using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using ShoppingCart_Problem;
using ShoppingCart_Solution;
using Delegate_Events;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           //SimpleDelegateSample();           
           //ShoppingCart_Example();
           //MulticastDelegate_Sample();
           //InBuiltDelegates();
        }        

        private static void ShoppingCart_Example()
        {
            ShoppingCart_Problem.ShoppingCart shoppingCart = new ShoppingCart_Problem.ShoppingCart();
            //ShoppingCart_Solution.ShoppingCart shoppingCart = new ShoppingCart_Solution.ShoppingCart();
            shoppingCart.ApplyDiscount();
        }    

        private static void SimpleDelegate_Sample()
        {
            SimpleDelegateSample simpleDelegateSample = new SimpleDelegateSample();
            simpleDelegateSample.TransformTest();            
        }

        private static void MulticastDelegate_Sample()
        {
            MulticastDelegate_Sample multicastDelegate = new MulticastDelegate_Sample();
            multicastDelegate.Run();
        }

        private static void InBuiltDelegates()
        {
            InBuiltDelegates inBuiltDelegates = new InBuiltDelegates(); 
            Console.WriteLine(inBuiltDelegates.Func_Method.Invoke(10)); //ConvertNumberToString
            inBuiltDelegates.Action_Method.Invoke("From Action Method"); //Display
            Console.WriteLine(inBuiltDelegates.Predicate_Method.Invoke(10)); //IsZero
            Console.WriteLine(inBuiltDelegates.Converter_Method.Invoke(20)); //ConvertNumberToString
            Console.WriteLine(inBuiltDelegates.Comparison_Method.Invoke("A","B")); //Compare
        }
    }       
}
