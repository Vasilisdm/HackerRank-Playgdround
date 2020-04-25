using System;
namespace HackerRank_Playground.WarmUP
{
    public static class Clouds
    {
        public static int JumpingOnClouds(int[] c)
        {
            int numberOfJumps = 0;

            for (int i = 0; i < c.Length - 1; i+=2)
            {
                if (c[i]==0)
                {
                    numberOfJumps++;
                }
                else
                {
                    i--;
                    numberOfJumps++;
                }
            }

            return numberOfJumps;
        }
    }
}
