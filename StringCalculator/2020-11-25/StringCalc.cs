using System;

namespace _2020_11_25
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(numbers.Contains(","))
            {

                string[] nums = numbers.Split(",");

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