using System;

namespace _2020_10_13
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(numbers.Contains(",") || numbers.Contains("\n"))
            {
                char[] deliniators = {',', '\n'};
                
                String[] nums = numbers.Split(deliniators);

                int sum = 0;

                foreach(string num in nums)
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
