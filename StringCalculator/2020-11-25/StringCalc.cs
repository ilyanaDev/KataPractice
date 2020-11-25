using System;

namespace _2020_11_25
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if(!string.IsNullOrEmpty(numbers))
            {
                return int.Parse(numbers);
            }
            
            return 0;
        }
    }
}