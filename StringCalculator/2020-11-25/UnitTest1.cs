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
    }
}
