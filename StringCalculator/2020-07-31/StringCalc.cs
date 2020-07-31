using System;
using System.Linq;
using Xunit;
using Xunit.Sdk;

namespace _2020_07_10
{
    public class StringCalc
    {
        public int Add(string nums)
        {
            char[] delimiters = { ',', '\n' };

            if(nums.Contains(",") || nums.Contains("\n"))
            {
                int sum = 0;

                string[] numsArray = nums.Split(delimiters);

                foreach (string num in numsArray)
                {
                    sum += int.Parse(num);
                }

                return sum;

            }

            if(nums.Length == 1)
            {
                return int.Parse(nums);
            }
            
            return 0;

        }
    }
}
