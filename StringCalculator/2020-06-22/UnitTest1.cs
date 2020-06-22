using System;
using Xunit;

namespace _2020_06_22
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

        [Theory]
        [InlineData("1")]
        [InlineData("17")]
        public void returnsNumGivenOneNum(string input)
        {
            // Arrange 
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(int.Parse(input), output);

        }
    }
}
