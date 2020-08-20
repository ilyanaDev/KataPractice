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
            if(string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            
            int sum = 0;

            char[] separators = { ',', '\n' };

            string[] numberArray = numbers.Split(separators);

            if (numberArray.Length > 0)
            {
                foreach(string n in numberArray)
                {
                    sum += int.Parse(n);
                }

                return sum;
            }

            return 0;
                        
        }

    }
}
