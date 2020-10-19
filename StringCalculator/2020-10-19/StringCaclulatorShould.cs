using System;
using Xunit;

namespace _2020_10_19
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroGivenEmpty()
        {
            string input = "";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(0, output);
        }
    }
}
