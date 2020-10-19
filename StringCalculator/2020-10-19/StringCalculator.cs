using System;
using Xunit;

namespace _2020_10_19
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(String.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char[] delimiters = { ',', '\n'};

            string[] nums = numbers.Split(delimiters);
            int sum = 0;

            foreach (string num in nums)
            {
                sum += int.Parse(num);
            }

            return sum;
        }
    }
}
