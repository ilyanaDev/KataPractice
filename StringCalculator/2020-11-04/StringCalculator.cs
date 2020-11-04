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

            if (numbers.Contains(","))
            {
                string[] nums = numbers.Split(",");

                int sum = 0;

                foreach (var num in nums)
                {
                    sum += int.Parse(num);
                }

                return sum;
            }
            
            return int.Parse(numbers);
        }
    }
}
