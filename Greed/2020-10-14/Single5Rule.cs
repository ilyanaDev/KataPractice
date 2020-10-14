using System.Collections.Generic;

namespace _2020_10_14
{
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
}