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

    }
}
