using System;

namespace Delegate_Events
{    
    public class InBuiltDelegates
    {
        public Func<int,string> Func_Method;
        public Action<string> Action_Method;
        public Predicate<int> Predicate_Method;
        public Converter<int,string> Converter_Method;
        public Comparison<string> Comparison_Method;

        public InBuiltDelegates()
        {
            Func_Method = ConvertNumberToString;
            Action_Method = Display;
            Predicate_Method = IsZero;
            Converter_Method = ConvertNumberToString;
            Comparison_Method = Compare;            
        }

        string ConvertNumberToString(int value)
        {
            return value.ToString();
        }

        void Display(string msg)
        {
            Console.WriteLine(msg);
        }

        bool IsZero(int value)
        {
            return value == 0;
        }

        int Compare(string val1, string val2)
        {
            return val1.CompareTo(val2);
        }
    }
}