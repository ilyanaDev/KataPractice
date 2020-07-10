using System;
using Xunit;

namespace _2020_07_10
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            if(numbers.Contains(",") || numbers.Contains("\n"))
            {
                char[] separators = {',', '\n' };

                string[] numbersArray = numbers.Split(separators);

                int sum = 0;

                foreach (string s in numbersArray)
                {
                    sum += int.Parse(s);
                }

                return sum;


            }

            return int.Parse(numbers);

        }
    }
}
