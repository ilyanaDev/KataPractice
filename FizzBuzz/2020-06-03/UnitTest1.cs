using System;
using Xunit;

namespace _2020_06_03
{
    public class FizzBuzz
    {
        public String fizzBuzz(int input) 
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (input % 3 == 0) 
            {
                return "Fizz";
            }
            if (input % 5 == 0) 
            {
                return "Buzz";
            }
            return input.ToString();
        }
    }
    
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void GivesInputGivenInput(int input)
        {
            
            var f = new FizzBuzz();
            String output = f.fizzBuzz(input);
            Assert.Equal(input.ToString(), output);
        }
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void GivesFizzGivenMultipleOf3(int input)
        {
            // Arrange
            var f = new FizzBuzz();

            // Act
            String output = f.fizzBuzz(input);

            // Assert
            Assert.Equal("Fizz", output);

        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void GivesBuzzGivenMultipleOf5(int input)
        {
            // Arrange
            var f = new FizzBuzz();

            // Act
            String output = f.fizzBuzz(input);

            // Assert
            Assert.Equal("Buzz", output);

        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void GivesFizzBuzzGivenMultipleOf3and5(int input)
        {
            // Arrange
            var f = new FizzBuzz();

            // Act
            String output = f.fizzBuzz(input);

            // Assert
            Assert.Equal("FizzBuzz", output);

        }
    }
}
