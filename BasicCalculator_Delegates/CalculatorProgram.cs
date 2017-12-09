namespace Demo.BasicCalculator_Delegates
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
            Console.WriteLine("Enter the operator to calculate");
            var operatorVal = Console.ReadLine();
            var addResult = calculator.Calculate(operatorVal).Invoke(inputs.ToArray());
            Console.WriteLine("Result : "+addResult);
        }
    }
}