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
            String input = "5";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(5, output);

        }

        [Fact]
        public void returnsSumGivenTwoNum()
        {
            // Arrange 
            String input = "5,2";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(7, output);

        }

        [Fact]
        public void returnsSumGivenManyNum()
        {
            // Arrange 
            String input = "5,21,7,13";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(46, output);

        }

        [Fact]
        public void returnsSumGivenNewLineDelimiter()
        {
            // Arrange 
            String input = "5,1\n6";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(12, output);

        }

        [Fact]
        public void returnsSumGivenUserInputDelimiter()
        {
            // Arrange 
            String input = "//;\n5,1\n6;3";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(15, output);

        }

        [Fact]
        public void throwsExceptionGivenNegs()
        {
            // Arrange 
            String input = "-4,3,-2";
            var s = new StringCalc();

            // Act
            var result = Assert.Throws<Exception>(() => s.Add(input));

            // Assert
            Assert.Equal("Negatives not allowed: -4,-2", result.Message);
        }

        [Fact]
        public void IgnoresNumsOver1000()
        {
            // Arrange 
            String input = "1000,2";
            var s = new StringCalc();

            // Act
            int output = s.Add(input);

            // Assert
            Assert.Equal(2, output);
        }


    }
}
