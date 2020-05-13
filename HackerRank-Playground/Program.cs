using System;
using HackerRank_Playground.Codewars.ArrayDiff;
using HackerRank_Playground.Codewars.VasyaClerk;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] ar1 = new int[] { 1,2 };
            int[] ar2 = new int[] { 1 };

            int[] ardiff = ArrayDiff.ElementSubtraction(ar1, ar2);

            foreach (var number in ardiff)
            {
                Console.WriteLine(number);

            }
        }
    }
}