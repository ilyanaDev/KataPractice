using System;
using Xunit;

namespace _2020_10_13
{
    public class UnitTest1
    {
        [Fact]
        public void Returns0GivenEmptyString()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "";

            int output = stringCalc.Add(input);

            Assert.Equal(0,output);
        }

        [Fact]
        public void ReturnsNumGivenOneNum()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "2";

            int output = stringCalc.Add(input);

            Assert.Equal(2,output);
        }

        [Fact]
        public void ReturnsSumGivenTwoNum()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "2,2";

            int output = stringCalc.Add(input);

            Assert.Equal(4,output);
        }

        [Fact]
        public void ReturnsSumGivenThreeNum()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "2,2,6";

            int output = stringCalc.Add(input);

            Assert.Equal(10,output);
        }

    
    }
}
