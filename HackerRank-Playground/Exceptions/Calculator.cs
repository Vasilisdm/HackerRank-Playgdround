using System;
namespace HackerRank_Playground.Exceptions
{
    public class Calculator
    {
        public int Power(int n, int p)
        {
            if (n<0 | p<0)
            {
                throw new Exception("n and p should be non-negative");
            }

            if (p==0)
            {
                return 1;
            }
            else
            {
                return n * Power(n, p - 1);
            }
        }
    }
}
