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

           if(nums.Contains("-"))
            {
                string negs = "";

                while(nums.Contains("-"))
                {
                    negs = negs + "-" + nums.Substring(nums.IndexOf("-") + 1, 1) + ",";

                    nums = nums.Substring(nums.IndexOf("-") + 1);
                }

                negs = negs.Substring(0, negs.Length - 1);

                string message = "Negatives not allowed: " + negs;

                throw new Exception(message);
            }

            if(nums.Contains("//"))
            {
                int sum = 0;

                char[] delimitersHere = nums.ToCharArray(2, 1);

                char[] delimitersNow = { delimitersHere[0], delimiters[0], delimiters[1] };

                string onlyNums = nums.Substring(nums.IndexOf("\n") + 1);

                string[] numsArray = onlyNums.Split(delimitersNow);

                foreach (string num in numsArray)
                {
                    sum += int.Parse(num);
                }

                return sum;

            }

            if (nums.Contains(",") || nums.Contains("\n"))
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
