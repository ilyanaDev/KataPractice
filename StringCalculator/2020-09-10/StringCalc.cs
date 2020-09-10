namespace _2020_09_10
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(numbers.Contains(",") || numbers.Contains("\n"))
            {
                char[] dividers = { ',', '\n' };
                
                string[] nums = numbers.Split(dividers);
                int sum = 0;

                foreach(string num in nums)
                {
                    sum += int.Parse(num);
                }
                return sum;
            }
    

            if (!string.IsNullOrEmpty(numbers))
            {
                return int.Parse(numbers);
            }
            
            return 0;
        }
    }
}