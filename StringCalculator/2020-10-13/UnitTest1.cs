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

        [Fact]
        public void ReturnsSumGivenThreeNumWithNewLine()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "2,2\n6";

            int output = stringCalc.Add(input);

            Assert.Equal(10,output);
        }

        [Fact]
        public void ReturnsSumGivenUserDefinedDelimiter()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "//;\n6;5;7";

            int output = stringCalc.Add(input);

            Assert.Equal(18,output);
        }

        [Fact]
        public void ThrowsExceptionGivenNegativeNumber()
        {
            StringCalculator stringCalc = new StringCalculator();

            String input = "-5,6,-2";

            Exception exception = Assert.Throws<ArgumentException>(() => stringCalc.Add(input));
            
            Assert.Equal("Negatives not allowed: -5,-2",exception.Message);

        }

    
    }
}
