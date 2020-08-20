using System;
using Xunit;

namespace _2020_08_20
{
    public class UnitTest1
    {
        [Fact]
        public void Returns0GivenEmpty()
        {
            //Arrange
            string input = "";
            StringCalc sc = new StringCalc();

            //Act
            int output = sc.Add(input);

            //Assert
            Assert.Equal(0, output);

        }

        [Fact]
        public void ReturnsNumGivenOneNum()
        {
            //Arrange
            string input = "5";
            StringCalc sc = new StringCalc();

            //Act
            int output = sc.Add(input);

            //Assert
            Assert.Equal(5, output);

        }

        [Fact]
        public void ReturnsSumGivenTwoNum()
        {
            //Arrange
            string input = "5,3";
            StringCalc sc = new StringCalc();

            //Act
            int output = sc.Add(input);

            //Assert
            Assert.Equal(8, output);

        }

        [Fact]
        public void ReturnsSumGivenFiveNum()
        {
            //Arrange
            string input = "5,3,1,1,4";
            StringCalc sc = new StringCalc();

            //Act
            int output = sc.Add(input);

            //Assert
            Assert.Equal(14, output);

        }

        [Fact]
        public void HandlesNewLineSeparator()
        {
            //Arrange
            string input = "5,3,1,1\n4";
            StringCalc sc = new StringCalc();

            //Act
            int output = sc.Add(input);

            //Assert
            Assert.Equal(14, output);

        }

        [Fact]
        public void HandlesDefinedDeliminator()
        {
            //Arrange
            string input = "//;\n3;2;1";
            StringCalc sc = new StringCalc();

            //Act
            int output = sc.Add(input);

            //Assert
            Assert.Equal(6, output);

        }

        [Fact]
        public void ThrowsExceptionGivenNegatives()
        {
            //Arrange
            string input = "2,4,-5,1,-3";
            StringCalc sc = new StringCalc();

            //Act
            var result = Assert.Throws<Exception>(() => sc.Add(input));

            // Assert
            Assert.Equal("Negatives not allowed: -5,-3,", result.Message);
        }
    }
}
