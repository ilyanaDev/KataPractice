using System;
using System.Collections.Generic;

namespace _2020_11_04
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char[] delimiters = { ',' , '\n'};

            if (numbers.StartsWith("//"))
            {
                delimiters[0] = char.Parse(numbers.Substring(2,1));
                delimiters[1] = char.Parse(numbers.Substring(2,1));

                numbers = numbers.Substring(4);
            }

            
            string[] nums = numbers.Split(delimiters);
            List<int> negs = new List<int>();

            int sum = 0;

            foreach (var num in nums)
            {

                if (int.Parse(num) < 0)
                {
                    negs.Add(int.Parse(num));
                }
                
                if (int.Parse(num) <= 1000)
                {
                    sum += int.Parse(num);
                }
            }

            if (negs.Count > 0)
            {
                string message = "Negatives not allowed: ";

                foreach(int neg in negs)
                {
                    message += neg + ",";
                }

                message = message.Substring(0, message.Length - 1);

                throw new Exception(message);
            }

            return sum;

        }
    }
}
