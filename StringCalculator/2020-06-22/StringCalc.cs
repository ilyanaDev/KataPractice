using System;
using Xunit;

namespace _2020_06_22
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if (numbers.Equals(""))
            {
                return 0;
            }

            return int.Parse(numbers);
        }
    }
}
