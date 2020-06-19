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
        [Fact]
        public void Test1()
        {

        }
    }
}
