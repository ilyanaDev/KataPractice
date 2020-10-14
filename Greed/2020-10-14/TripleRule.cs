using System.Collections.Generic;

namespace _2020_10_14
{
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
}