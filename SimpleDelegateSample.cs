using System;

namespace Demo
{
    delegate int Transform(int x);
    
    public class SimpleDelegateSample
    {
        int Square(int x) => x * x;

        int Add(int x) => x + x;

        int DoubleTransform(int x, Transform trans) => trans(trans(x));

        public void TransformTest()
        {
            delegateTest t = Square;                // Create delegate instance
            var result = t(3);                      // Invoke delegate        
            var result2 = t.Invoke(5);              // Invoke delegate
            var result3 = DoubleTransform(6, Add);  // Delegate as parameter
            Console.WriteLine("{0} {1} {2}", result, result2, result3);
        }
    }
}
