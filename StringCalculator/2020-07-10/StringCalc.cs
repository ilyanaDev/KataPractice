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
            string numbers = nums;
            char[] separators = { ',', '\n' };

            if (numbers.Length == 0)
            {
                return 0;
            }

            //testing for user-defined delimiter
            if(numbers.Contains("//"))
            {
                //assuming user never inputs \n as delimiter
                int indexOfNumStart = numbers.IndexOf("\n");

                string numberStore = numbers;

                numbers = numbers.Substring(indexOfNumStart + 1);

                for(int i = 0; i < separators.Length; i++)
                {
                    separators[i] = char.Parse(numberStore.Substring(indexOfNumStart - 1, 1));
                }

            }

            if(numbers.Contains("-"))
            {
                string negsList = "";
                bool foundNegBefore = false;

                for(int i = 0; i < numbers.Length; i++)
                {
                    if(numbers.Substring(i,1).Equals("-"))
                    {
                        if(foundNegBefore)
                        {
                            negsList = negsList + ",";
                        }

                        negsList = negsList + numbers.Substring(i, 2);

                        foundNegBefore = true;

                    }
                }

                throw new Exception("Negatives not allowed: " + negsList);
            }

            //actual calculations for output
            if(numbers.Contains(separators[0]) || numbers.Contains(separators[1]))
            {

                string[] numbersArray = numbers.Split(separators);

                int sum = 0;

                foreach (string s in numbersArray)
                {
                    sum += int.Parse(s);
                }

                return sum;


            }

            return int.Parse(numbers);

        }
    }
}
