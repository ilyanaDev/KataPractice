using System;

namespace _2020_11_25
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(numbers.Contains(","))
            {
                string num1 = numbers.Substring(0, numbers.IndexOf(","));
                string num2 = numbers.Substring(numbers.IndexOf(",") + 1);

                int sum = int.Parse(num1) + int.Parse(num2);
                return sum;
            }
            
            if(!string.IsNullOrEmpty(numbers))
            {
                return int.Parse(numbers);
            }
            
            return 0;
        }
    }
}