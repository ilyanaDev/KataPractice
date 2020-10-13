using System;

namespace _2020_10_13
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(String.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            
            String[] nums;

            char[] delimiter = new char[2];

            if(numbers.StartsWith("//"))
            {
                delimiter[0] = char.Parse(numbers.Substring(2,1));

                numbers = numbers.Substring(4);

            }

            else
            {
                delimiter[0] = ',';
                delimiter[1] = '\n';

            }

            nums = numbers.Split(delimiter);


            int sum = 0;

            foreach(string num in nums)
            {
                sum += int.Parse(num);
            }

            return sum;            

                        
        }
    }
}
