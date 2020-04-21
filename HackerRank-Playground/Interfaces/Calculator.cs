using System;
using System.Collections.Generic;
using HackerRank_Playground.Interface;

namespace HackerRank_Playground.Interfaces
{
    public class Calculator : AdvancedArithmetic
    {
        private int[] divisorArray = new int[100];

        public int divisorSum(int n)
        {
            int sum = 0;
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i ==0)
                {
                    divisorArray[j++] = i;
                }
            }

            foreach (var divisor in divisorArray)
            {
                sum += divisor;
            }

            return sum;
        }
    }
}
