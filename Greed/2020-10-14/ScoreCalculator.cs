using System.Collections.Generic;

namespace _2020_10_14
{
    public class ScoreCalculator
    {
        private List<IRule> Rules = new List<IRule>();

        public ScoreCalculator()
        {
            Rules.Add(new TripleOneRule());
            
            Rules.Add(new TripleRule(2));
            Rules.Add(new TripleRule(3));
            Rules.Add(new TripleRule(4));
            Rules.Add(new TripleRule(5));
            Rules.Add(new TripleRule(6));

            Rules.Add(new Single1Rule());
            Rules.Add(new Single5Rule());
        }

        public int CalculateScore(List<int> dice)
        {
            int score = 0;
            List<int> myDice = dice;

            foreach(IRule rule in Rules)
            {
                score += rule.Score(myDice);
            }
            
            return score;
        }
    }

    public interface IRule
    {
        public int Score(List<int> dice);
    }

    public class Single1Rule : IRule
    {
        public int Score(List<int> dice)
        {
            int score = 0;

            List<int> diceToRemove = new List<int>();

            foreach (int i in dice)
            {
                if(i == 1)
                {
                    score += 100;
                    diceToRemove.Add(i);
                }
            }

            foreach (int i in diceToRemove)
            {
                dice.Remove(i);
            }


            return score;
        }
    }
    public class Single5Rule : IRule
    {
        public int Score(List<int> dice)
        {
            int score = 0;

            List<int> diceToRemove = new List<int>();

            foreach (int i in dice)
            {
                if(i == 5)
                {
                    score += 50;
                    diceToRemove.Add(i);
                }
            }

            foreach (int i in diceToRemove)
            {
                dice.Remove(i);
            }

            return score;
        }
    }
    
    public class TripleRule : IRule
    {   
        private int tripleNum;

        public TripleRule(int num)
        {
            tripleNum = num;
        }
        public int Score(List<int> dice)
        {
            int score = 0;

            List<int> allOfTripleNum = dice.FindAll(i => i == tripleNum);

            if(dice.Count < 3 || allOfTripleNum.Count < 3)
            {
                return score;
            }

            score = 100 * tripleNum;

            dice.Remove(tripleNum);
            dice.Remove(tripleNum);
            dice.Remove(tripleNum);

            return score;
        }
    }
    public class TripleOneRule : IRule
    {   
        private int tripleNum = 1;

        public int Score(List<int> dice)
        {
            int score = 0;

            List<int> allOfTripleNum = dice.FindAll(i => i == tripleNum);

            if(dice.Count < 3 || allOfTripleNum.Count < 3)
            {
                return score;
            }

            score = 1000;

            dice.Remove(tripleNum);
            dice.Remove(tripleNum);
            dice.Remove(tripleNum);

            return score;
        }
    }
}