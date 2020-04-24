using System;
namespace HackerRank_Playground.WarmUP
{
    public static class Hike
    {
        public static int CountValleys(int n, string s)
        {
            int altitude = 0;
            int valleyCounter = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if (++altitude == 0)
                    {
                        valleyCounter++;
                    }
                }
                else
                {
                    altitude--;
                }
            }
            return valleyCounter;
        }
    }
}
