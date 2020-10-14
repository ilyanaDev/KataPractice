using System;
using System.Collections.Generic;
using Xunit;

namespace _2020_10_14
{
    public class ScoreCalculatorShould
    {
        [Fact]
        public void GiveScoreOf0GivenNo1or5orTriple()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 4, 2, 2, 3, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(0, output);
        }

        [Fact]
        public void GiveScoreOf100Given1AndNo5OrTriple()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 1, 2, 2, 3, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(100, output);
        }

        [Fact]
        public void GiveScoreOf50Given5AndNo1OrTriple()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 5, 2, 2, 3, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(50, output);
        }

        [Fact]
        public void GiveScoreOf1000GivenTriple1()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 1, 1, 1, 3, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(1000, output);
        }

        [Fact]
        public void GiveScoreOf1100GivenQuadruple1()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 1, 1, 1, 1, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(1100, output);
        }

        [Fact]
        public void GiveScoreOf200GivenTriple2()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 2, 2, 2, 3, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(200, output);
        }

        [Fact]
        public void GiveScoreOf300GivenTriple3()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 2, 2, 3, 3, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(300, output);
        }

        [Fact]
        public void GiveScoreOf400GivenTriple4()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 2, 2, 4, 4, 4 };

            int output = sc.CalculateScore(input);

            Assert.Equal(400, output);
        }

        [Fact]
        public void GiveScoreOf500GivenTriple5()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 2, 2, 5, 5, 5 };

            int output = sc.CalculateScore(input);

            Assert.Equal(500, output);
        }

        [Fact]
        public void GiveScoreOf600GivenTriple6()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 2, 2, 6, 6, 6 };

            int output = sc.CalculateScore(input);

            Assert.Equal(600, output);
        }

        [Fact]
        public void GiveScoreOf300GivenTriple2And1()
        {
            ScoreCalculator sc = new ScoreCalculator();

            List<int> input = new List<int>{ 2, 2, 2, 1, 3 };

            int output = sc.CalculateScore(input);

            Assert.Equal(300, output);
        }

    }
}
