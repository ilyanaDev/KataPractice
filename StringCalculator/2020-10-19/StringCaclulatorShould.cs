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

        [Fact]
        public void ReturnSumGivenThreeNum()
        {
            string input = "5,4,2";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(11, output);
        }

        [Fact]
        public void ReturnSumGivenNewLine()
        {
            string input = "5\n4\n2";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(11, output);
        }

        [Fact]
        public void ReturnSumGivenUserInputDelimiter()
        {
            string input = "//;\n5;4;2";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(11, output);
        }

        [Fact]
        public void ThrowsErrorGivenNeg()
        {
            string input = "5,4,-2,-1";
            StringCalculator sc = new StringCalculator();

            var result = Assert.Throws<Exception>(() => sc.Add(input));

            Assert.Equal("Negatives not allowed: -2,-1", result.Message);
        }

        [Fact]
        public void IgnoresNumsOver1000ButKeeps1000()
        {
            string input = "5\n4\n2,1000,1001";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(1011, output);
        }

        [Fact]
        public void HandlesAnyLengthDelimiters()
        {
            string input = "//[|||]\n1|||2|||3";
            StringCalculator sc = new StringCalculator();

            int output = sc.Add(input);

            Assert.Equal(6, output);
        }
    }
}
