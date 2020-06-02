using System;
using Xunit;

// https://github.com/ardalis/kata-catalog/blob/master/katas/FizzBuzz.md

namespace fizzbuzz
{
    public class Formatter 
    {
        public string FizzBuzz(int input) 
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
    
    public class Formatter_FizzBuzz
    {
        private Formatter _formatter = new Formatter();

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Returns1Given1(int input)
        {
            // Act
            var result = _formatter.FizzBuzz(input);

            // Assert
            Assert.Equal(input.ToString(), result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(12)]
        public void ReturnsFizzGivenMultipleOf3(int input)
        {
            // Act
            var result = _formatter.FizzBuzz(input);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void ReturnsBuzzGivenMultipleOf5(int input)
        {
            // Act
            var result = _formatter.FizzBuzz(input);

            // Assert
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void ReturnsBuzzGivenMultipleOf3And5(int input)
        {
            // Act
            var result = _formatter.FizzBuzz(input);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }
    }
}
