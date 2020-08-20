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

            char[] delimitors = { ',', '\n' };


            if (numbers.StartsWith("//"))
            {
                delimitors[1] = numbers[2];

                numbers = numbers.Substring(4);                  
            }

            int sum = 0;

            string[] numberArray = numbers.Split(delimitors);

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
