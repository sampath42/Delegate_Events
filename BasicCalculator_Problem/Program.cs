namespace Demo.BasicCalculator_Problem
{
    using System;
    using System.Collections.Generic;
    public class CalculatorProgram
    {
        public static void Main2(string[] args) 
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("======Basic Calculator======");
            Console.WriteLine("Enter inputs to add separated by new line and press 'C' to calculate");
            List<double> inputs = new List<double>();
            bool isCalculate = true;
            do
            {
                var input = Console.ReadLine();
                isCalculate = input.Equals("C",StringComparison.OrdinalIgnoreCase);
                if(isCalculate)
                {
                    break;
                }
                inputs.Add(Convert.ToDouble(input));
            }while(true);

            var addResult = calculator.Add(inputs.ToArray());
            Console.WriteLine("Result : "+addResult);
        }
    }
}