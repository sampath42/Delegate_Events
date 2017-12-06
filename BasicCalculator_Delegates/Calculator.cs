namespace Demo.BasicCalculator_Delegates
{
    using System;
    using System.Linq;
    public class Calculator
    {
        public delegate double CalculatePointer(params double[] values);

        public CalculatePointer Calculate(string operatorValue)
        {
            switch(operatorValue)                 
            {
                case "+":
                case "Add":
                case "add":
                    return Add;
                case "-":
                case "Subtract":
                case "subtract":
                    return Subtract;
                default:
                    return null;
            }
        }
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