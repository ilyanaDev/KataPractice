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
        public void ReturnSumGivenNewLineDelim()
        {
            string input = "6,7,2,0\n1";
            StringCalc sc = new StringCalc();

            var output = sc.Add(input);

            Assert.Equal(16, output);
        }
    }
}
