using System;
using Xunit;

namespace _2020_07_10
{
    public class UnitTest1
    {
        [Fact]
        public void returns0GivenEmpty()
        {
            // Arrange 
            String input = "";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(0, output);

        }

        [Fact]
        public void returnsNumGivenOneNum()
        {
            // Arrange 
            String input = "56";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(56, output);

        }

        [Fact]
        public void returnsSumGivenTwoNum()
        {
            // Arrange 
            String input = "11,5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(16, output);

        }

        [Fact]
        public void returnsSumGivenThreeNum()
        {
            // Arrange 
            String input = "11,5,7";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(23, output);

        }

        [Fact]
        public void returnsSumGivenFiveNum()
        {
            // Arrange 
            String input = "11,5,7,3,1";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(27, output);

        }

        [Fact]
        public void returnsSumGivenNewLineSeparator()
        {
            // Arrange 
            String input = "1\n4,7";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(12, output);

        }

        [Fact]
        public void returnsSumGivenDefinedDelimiter()
        {
            // Arrange 
            String input = "//&\n0&7&5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(12, output);

        }

        [Fact]
        public void returnsNegsException()
        {
            // Arrange 
            String input = "-1,0,-5";
            var s = new StringCalc();

            // Act
            //int output = s.Add(input);
            var result = Assert.Throws<Exception>(() => s.Add(input));

            // Assert
            Assert.Equal("Negatives not allowed: -1,-5",result.Message);

        }

    }
}
