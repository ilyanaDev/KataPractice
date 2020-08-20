using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using Xunit.Sdk;

namespace _2020_08_20
{
    class StringCalc
    {
        public int Add(string numbers)
        {
            int sum = 0;

            if(numbers.Contains(","))
            {
                string[] numberArray = numbers.Split(",");

                foreach(string n in numberArray)
                {
                    sum += int.Parse(n);
                }

                return sum;
            }
            
            if(!(numbers.Contains(",")) && numbers.Length > 0)
            {
                return int.Parse(numbers);
            }
            
            return 0;
        }

    }
}
