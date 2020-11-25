using System;

namespace _2020_11_25
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(numbers.StartsWith("//"))
            {
                char delimiter = char.Parse(numbers.Substring(2,1));
                numbers = numbers.Substring(4);

                string[] nums = numbers.Split(delimiter);

                int sum = 0;

                foreach (string num in nums)
                {
                    sum += int.Parse(num);
                }

                return sum;
                
            }
            
            if(numbers.Contains(",") || numbers.Contains("\n"))
            {
                char[] delimiters = { ',' , '\n'};

                string[] nums = numbers.Split(delimiters);

                int sum = 0;

                foreach (string num in nums)
                {
                    sum += int.Parse(num);
                }

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