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
    }
}
