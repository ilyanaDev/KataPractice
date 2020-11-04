using System;
using Xunit;

namespace _2020_11_04
{
    public class UnitTest1
    {
        [Fact]
        public void Returns0GivenEmpty()
        {
            var input = "";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(0, output);
        }

        [Fact]
        public void ReturnsNumGivenNum()
        {
            var input = "5";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(5, output);
        }

        [Fact]
        public void ReturnsSumGivenTwoNum()
        {
            var input = "5,7";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(12, output);
        }

        [Fact]
        public void ReturnsSumGivenFourNum()
        {
            var input = "5,7,2,0";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(14, output);
        }

        [Fact]
        public void HandlesNewLineDelimiter()
        {
            var input = "5,7\n2,0";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(14, output);
        }

        [Fact]
        public void HandlesCustomDelimiter()
        {
            var input = "//;\n5;7;2;4";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(18, output);
        }

        [Fact]
        public void ThrowsExceptionGivenNeg()
        {
            var input = "5,6,-2,6,-1";

            StringCalculator sc = new StringCalculator();
            
            var result = Assert.Throws<Exception>(() => sc.Add(input));

            Assert.Equal("Negatives not allowed: -2,-1", result.Message);
        }

        [Fact]
        public void IgnoresNumsOver1000()
        {
            var input = "5,7,2,1001, 1000";

            StringCalculator sc = new StringCalculator();

            var output = sc.Add(input);
            
            Assert.Equal(1014, output);
        }

    }
}
