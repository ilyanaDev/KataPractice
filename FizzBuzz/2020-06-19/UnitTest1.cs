using System;
using Xunit;

//https://github.com/ardalis/kata-catalog/blob/master/katas/FizzBuzz.md

// the FizzBuzz kata with the pseudocode programming process, then writing tests

namespace _2020_06_19
{
    public class Formatter
    {
        public string FizzBuzz(int input) 
        {
            // if input is divisible by 3 and 5, return "FizzBuzz"
            if (input % 3 == 0 && input % 5 == 0) 
            {
                return "FizzBuzz";
            }
            // if input is divisible by 3 or 5
                // if input is divisible by 3, return "Fizz"
            if (input % 3 == 0)
            {
                return "Fizz";
            }
                // if input is divisible by 5, return "Buzz"
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            //else return input
            return input.ToString();
        }
    }
    
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void GivesInputGivenInput(int input)
        {
            // Arrange
            var fb = new Formatter();

            // Act
            String output = fb.FizzBuzz(input);

            // Assert
            Assert.Equal(input.ToString(), output);

        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void GivesFizzGivenMultOf3(int input)
        {
            // Arrange
            var fb = new Formatter();

            // Act
            String output = fb.FizzBuzz(input);

            // Assert
            Assert.Equal("Fizz", output);

        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void GivesBuzzGivenMultOf5(int input)
        {
            // Arrange
            var fb = new Formatter();

            // Act
            String output = fb.FizzBuzz(input);

            // Assert
            Assert.Equal("Buzz", output);

        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void GivesFizzBuzzGivenMultOf3and5(int input)
        {
            // Arrange
            var fb = new Formatter();

            // Act
            String output = fb.FizzBuzz(input);

            // Assert
            Assert.Equal("FizzBuzz", output);

        }


    }
}
