using System;
using Xunit;
using System.Collections.Generic;

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

            if (numbers.StartsWith("//"))
            {
                if(numbers.Contains("["))
                {
                    string delim = numbers.Substring(numbers.IndexOf("[") + 1, numbers.IndexOf("]"));

                    numbers = numbers.Substring(numbers.IndexOf("]\n") + 2);

                    nums = numbers.Split(delim);
                }

                else
                {
                char delimiter = char.Parse( numbers.Substring(2,1));
                delimiters[0] = delimiter;
                delimiters[1] = delimiter;

                numbers = numbers.Substring(4);

                nums = numbers.Split(delimiters);

                }
            }


            if(numbers.Contains("-"))
            {
                string message = "Negatives not allowed: ";

                List<int> negatives = new List<int>();

                foreach (string num in nums)
                {
                    if(num.Contains("-"))
                    {
                        negatives.Add(int.Parse(num));
                    }
                }

                foreach(int neg in negatives)
                {
                    message = message + neg + ",";
                }

                message = message.Substring(0, message.Length - 1);

                throw new Exception(message);
            }


            int sum = 0;

            foreach (string num in nums)
            {
                if(int.Parse(num) <= 1000)
                {
                    sum += int.Parse(num);
                }
            }

            return sum;
        }
    }
}
