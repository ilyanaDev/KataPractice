namespace _2020_11_04
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char[] delimiters = { ',' , '\n'};

            if (numbers.StartsWith("//"))
            {
                delimiters[0] = char.Parse(numbers.Substring(2,1));
                delimiters[1] = char.Parse(numbers.Substring(2,1));

                numbers = numbers.Substring(4);
            }

            
            string[] nums = numbers.Split(delimiters);

            int sum = 0;

            foreach (var num in nums)
            {
                sum += int.Parse(num);
            }

            return sum;

        }
    }
}
