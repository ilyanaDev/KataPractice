using System;
using System.Collections.Generic;

namespace _2020_11_25
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char[] delimiters = { ',' , '\n'};

            if(numbers.StartsWith("//["))
            {
                int delimiterLength = numbers.IndexOf("]") - numbers.IndexOf("[") - 1;

                string delimiter = numbers.Substring(numbers.IndexOf("[") + 1, delimiterLength);

                numbers = numbers.Substring(numbers.IndexOf("\n") + 1);

                string[] nums1 = numbers.Split(delimiter);

                int sum1 = 0;

                List<int> negs1 = new List<int>();

                foreach (string num in nums1)
                {

                    if(int.Parse(num) <= 1000)
                    {
                        sum1 += int.Parse(num);
                    }

                    if(int.Parse(num) < 0)
                    {
                        negs1.Add(int.Parse(num));
                    }
                }

                if (negs1.Count > 0)
                {
                    string message = "Negatives not allowed: ";

                    foreach(int num in negs1)
                    {
                        message = message + num + ",";
                    }

                    message = message.Substring(0, message.Length - 1);

                    throw new Exception(message);
                }

                return sum1;

            }
            
            if(numbers.StartsWith("//"))
            {
                delimiters[0] = char.Parse(numbers.Substring(2,1));
                delimiters[1] = char.Parse(numbers.Substring(2,1));
                numbers = numbers.Substring(4);
            }

            string[] nums = numbers.Split(delimiters);

            int sum = 0;

            List<int> negs = new List<int>();

            foreach (string num in nums)
            {
                if(int.Parse(num) <= 1000)
                {
                    sum += int.Parse(num);
                }

                if(int.Parse(num) < 0)
                {
                    negs.Add(int.Parse(num));
                }
            }

            if (negs.Count > 0)
            {
                string message = "Negatives not allowed: ";

                foreach(int num in negs)
                {
                    message = message + num + ",";
                }

                message = message.Substring(0, message.Length - 1);

                throw new Exception(message);
            }

            return sum;
                                        
        }
    }
}