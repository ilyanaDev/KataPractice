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

            if(numbers.Contains("-"))           
            {
                string negs = "";

                for(int i = 0; i < numbers.Length; i++)
                {
                    if(numbers.Substring(i,1) == "-")
                    {
                        negs = negs + numbers.Substring(i,2) + ",";
                    }
                }

                negs = negs.Substring(0,negs.Length - 1);
                
                throw new ArgumentException("Negatives not allowed: " + negs);
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
