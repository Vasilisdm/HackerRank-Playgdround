using System;
namespace HackerRank_Playground.Complexity
{
    public static class Prime
    {
        public static bool IsPrime(int n)
        {
            //if (n < 2) return false;

            //var r = System.Convert.ToInt32(Math.Floor(Math.Sqrt(n)));

            //for (var i = 2; i <= r; ++i)
            //    if (n % i == 0) return false;

            //return true;

            int divisorCounter = 0;

            if (n>1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        divisorCounter++;
                    }
                }
                if (divisorCounter == 2)
                { 
                    return true;
                }

                if (divisorCounter > 2)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
