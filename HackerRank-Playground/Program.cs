using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HackerRank_Playground.GregorianCalendar;
using HackerRank_Playground.WarmUP;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                Console.WriteLine(TestCase(n, k));
            }
        }

        static int TestCase(int n, int k)
        {
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    int val = i & j;
                    if (max < val && val < k)
                    {
                        max = val;
                    }
                }
            }
            return max;
        }
    }
}
