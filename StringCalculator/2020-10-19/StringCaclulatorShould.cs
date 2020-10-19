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

        [Fact]
        public void ReturnNumGivenOneNum()
        {
            string input = "5";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(5, output);
        }

        [Fact]
        public void ReturnSumGivenTwoNum()
        {
            string input = "5,4";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(9, output);
        }
    }
}