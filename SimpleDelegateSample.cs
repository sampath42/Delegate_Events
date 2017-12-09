using System;

namespace Demo
{
    delegate int Transform(int x);
    delegate int delegateTest(int x);
    
    public class SimpleDelegateSample
    {
        int Square(int x) => x * x;

        int Add(int x) => x + x;

        int DoubleTransform(int x, Transform trans) => trans(x);

        public void TransformTest()
        {
            delegateTest test = Square;                // Create delegate instance
            var result = test(3);                      // Invoke delegate
            var result2 = test.Invoke(5);              // Invoke delegate
            var result3 = DoubleTransform(6, Add);     // Delegate as parameter
            Console.WriteLine("{0} {1} {2}", result, result2, result3);            
        }
    }
}
