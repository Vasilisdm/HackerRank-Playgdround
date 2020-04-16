using System;
namespace HackerRank_Playground.Scope
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] el)
        {
            elements = el;
        }

        public void computeDifference()
        {
            for (int i = 0; i < elements.Length-1; i++)
            {
                for (int j = 0; j < elements.Length-1; j++)
                {
                    if (Math.Abs(elements[i] - elements[j + 1]) > maximumDifference)
                    {
                        maximumDifference = Math.Abs(elements[i] - elements[j + 1]);
                    }
                }
            }
        }
    }
}
