using System;
using Xunit;

namespace _2020_07_10
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            return int.Parse(numbers);

        }
    }
}
