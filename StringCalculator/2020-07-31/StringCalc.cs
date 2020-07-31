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
            if(nums.Contains(","))
            {
                int sum = 0;

                string[] numsArray = nums.Split(",");

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
