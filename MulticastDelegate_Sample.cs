using System;

namespace Demo
{
    public delegate void MyDelegate(int arg1, ref int arg2);
    public class MulticastDelegate_Sample
    {
        public void func1(int arg1, ref int arg2)
        {
            int result = arg1 + arg2;
            arg2 += 20;
            Console.WriteLine($"result : {result} -- arg2 : {arg2}");
        }

        public void func2(int arg1, ref int arg2)
        {
            int result = arg1 * arg2;
            Console.WriteLine($"result : {result} -- arg2 : {arg2}");
        }

        public void Run()
        {
            int a = 10, b = 10;
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate combined = f1 + f2;
            combined(a, ref b);
        }
    }
}