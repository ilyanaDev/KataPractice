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

            if (numbers.Contains("-"))
            {
                string negativesMessage = "Negatives not allowed: ";

                for(int i = 0; i < numbers.Length - 1; i++)
                {
                    if(numbers[i].Equals('-'))
                    {
                        negativesMessage += "-" + numbers[i + 1] + ",";
                    }
                }

                //negativesMessage = negativesMessage.Substring(0, negativesMessage.Length - 1);

                throw new Exception(negativesMessage);
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
