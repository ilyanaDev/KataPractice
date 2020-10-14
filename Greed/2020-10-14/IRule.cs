using System.Collections.Generic;

namespace _2020_10_14
{
    public interface IRule
    {
        public int Score(List<int> dice);
    }
}