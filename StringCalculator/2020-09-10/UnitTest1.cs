using System;
using Xunit;

namespace _2020_09_10
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyStringReturns0()
        {
            // Arrange
            var sc = new StringCalc();
            int expected = 0;
            string input = "";

            // Act
            int output = sc.Add(input);

            // Assert
            Assert.Equal(expected, output);

        }

        [Fact]
        public void StringWithOneNumReturnsNum()
        {
            // Arrange
            var sc = new StringCalc();
            int expected = 5;
            string input = "5";

            // Act
            int output = sc.Add(input);

            // Assert
            Assert.Equal(expected, output);

        }

        [Fact]
        public void StringWithTwoNumReturnsSum()
        {
            // Arrange
            var sc = new StringCalc();
            int expected = 19;
            string input = "10,9";

            // Act
            int output = sc.Add(input);

            // Assert
            Assert.Equal(expected, output);

        }

        [Fact]
        public void StringWithThreeNumReturnsSum()
        {
            // Arrange
            var sc = new StringCalc();
            int expected = 27;
            string input = "8,10,9";

            // Act
            int output = sc.Add(input);

            // Assert
            Assert.Equal(expected, output);

        }

        [Fact]
        public void StringWithNewLineSplitReturnsSum()
        {
            // Arrange
            var sc = new StringCalc();
            int expected = 27;
            string input = "8,10\n9";

            // Act
            int output = sc.Add(input);

            // Assert
            Assert.Equal(expected, output);

        }

        [Fact]
        public void HandlesUserDefinedDelimeter()
        {
            // Arrange
            var sc = new StringCalc();
            int expected = 27;
            string input = "//;\n8;10;9";

            // Act
            int output = sc.Add(input);

            // Assert
            Assert.Equal(expected, output);

        }
    }
}
