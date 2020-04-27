using System;
using System.Collections.Generic;

namespace HackerRank_Playground.WarmUP
{
    public static class RepeatedString
    {
        public static long AOccurances(string s, long n)
        {
            long sOccurances = n / s.Length;
            long remainderOfS = n % s.Length;

            if (!s.Contains('a'))
            {
                return 0;
            }

            return s.Length > n ?
                Counter(s, remainderOfS) : sOccurances * Counter(s, s.Length) + Counter(s, remainderOfS);
        }

        public static long Counter(String s, long end)
        {
            int timesOfA = 0;
            for (int i = 0; i < end; i++)
            {
                if (s[i] == 'a')
                {
                    timesOfA++;
                }
            }
            return timesOfA;
        }

    }
}
