using System.Collections.Generic;

namespace _2020_09_10
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            
            char[] delimeter = { ',', '\n' };

            if (numbers.StartsWith("//"))
            {
                delimeter[0] = char.Parse(numbers.Substring(2, 1));
                numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
            }

            string[] nums = numbers.Split(delimeter);

            List<string> negs = new List<string>();

            foreach(var num in nums)
            {
                if (int.Parse(num) < 0)
                {
                    negs.Add(num);
                }
            }

            if(negs.Count > 0)
            {
                string message = "Negatives not allowed: ";

                foreach(var num in negs)
                {
                    message = message + num + ",";
                }

                message = message.Substring(0, message.Length - 1);

                throw new System.ArgumentException(message);
            }

            return Sum(nums);

        }

        public int Sum(string[] nums)
        {
            int sum = 0;
            foreach (string num in nums)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
    }
}