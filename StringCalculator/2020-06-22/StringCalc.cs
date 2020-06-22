using System;
using Xunit;

namespace _2020_06_22
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if (numbers.Equals(""))
            {
                return 0;
            }

            char[] allowableChars = {',', '\n'}; 

            string[] nums = numbers.Split(allowableChars);
            int sum = 0;

            foreach (var num in nums)
            {
                int numint = int.Parse(num);
                sum += numint;
            }

            return sum;

        }
    }
}
