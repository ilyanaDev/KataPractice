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

        [Theory]
        [InlineData("2,2")]
        [InlineData("1,3")]
        [InlineData("3,1")]
        public void returnsSum4GivenTwoNum(string input)
        {
            // Arrange 
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(4, output);

        }

        [Fact]
        public void returnsSumGivenTwoNum()
        {
            // Arrange 
            String input = "18,3";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(21, output);

        }

        [Fact]
        public void returnsSumGivenAnyNumNum1()
        {
            // Arrange 
            String input = "2,2,5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(9, output);

        }

        [Fact]
        public void returnsSumGivenAnyNumNum2()
        {
            // Arrange 
            String input = "1,3,6,2,4,5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(21, output);

        }

        [Fact]
        public void returnsSumGivenAnyNumNum3()
        {
            // Arrange 
            String input = "3,1,2,5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(11, output);

        }

        [Fact]
        public void returnsSumGivenAnyNumsDeliminatedByNewLine()
        {
            // Arrange 
            String input = "3\n1\n2\n5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(11, output);

        }
    }
}
