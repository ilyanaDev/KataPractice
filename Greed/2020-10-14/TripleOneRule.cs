using System.Collections.Generic;

namespace _2020_10_14
{
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