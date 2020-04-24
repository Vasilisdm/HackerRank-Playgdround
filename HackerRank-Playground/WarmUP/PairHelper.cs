using System;
using System.Collections.Generic;

namespace HackerRank_Playground.WarmUP
{
    public static class PairHelper
    {
        public static int sockMerchant(int n, int[] ar)
        {
            int pairCounter = 0;
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (var number in ar)
            {
                if (!pairs.ContainsKey(number))
                {
                    pairs.Add(number, 1);
                }
                else
                {
                    pairs[number]++;
                    if (pairs[number]%2==0)
                    {
                        pairCounter++;
                    }
                }
            }

            return pairCounter;
        }
    }
}
