namespace Demo.BasicCalculator_Problem
{
    using System.Linq;
    public class Calculator
    {
        public double Add(params double [] items)
        {
            return items.Sum();
        }

        public double Subtract(params double [] items)
        {
            var result = 0.0;
            foreach(double item in items)
            {
                result -= item;
            }
            return result;
        }
    }
}