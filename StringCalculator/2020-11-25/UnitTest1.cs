using System;
using Xunit;

namespace _2020_11_25
{
    public class StringCalcShould
    {
        
        [Fact]
        public void Return0GivenEmpty()
        {
            string input = "";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(0, output);
        }

        [Fact]
        public void ReturnNumGivenOneNum()
        {
            string input = "67";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(67, output);
        }

        [Fact]
        public void ReturnSumGivenTwoNum()
        {
            string input = "6,7";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(13, output);
        }

        [Fact]
        public void ReturnSumGivenFiveNum()
        {
            string input = "6,7,2,0,1";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(16, output);
        }

        [Fact]
        public void ReturnSumGivenNewLineDelimiter()
        {
            string input = "6,7,2,0\n1";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(16, output);
        }

        [Fact]
        public void ReturnSumGivenUserDefinedDelimiter()
        {
            string input = "//;\n6;7;2;0;1";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(16, output);
        }

        [Fact]
        public void ThrowsExceptionGivenNegative()
        {
            string input = "5,-2,0,-1";
            StringCalc sc = new StringCalc();

            var result = Assert.Throws<Exception>(() =>sc.Add(input));

            Assert.Equal("Negatives not allowed: -2,-1", result.Message);
        }

        [Fact]
        public void IgnoreNumsGreaterThan1000()
        {
            string input = "5,1000,1001,3";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(1008, output);
        }

        [Fact]
        public void HandlesAnyLengthDelimiter()
        {
            string input = "//[|||]\n5|||1000|||1001|||3";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(1008, output);
        }
    }
}
