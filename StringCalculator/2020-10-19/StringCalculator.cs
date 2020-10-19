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

            if (numbers.StartsWith("//"))
            {
                char delimiter = char.Parse( numbers.Substring(2,1));
                delimiters[0] = delimiter;

                numbers = numbers.Substring(4);
            }

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
