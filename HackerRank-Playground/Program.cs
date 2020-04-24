using System;
using HackerRank_Playground.BST;
using HackerRank_Playground.WarmUP;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = PairHelper.sockMerchant(n, ar);

            Console.WriteLine($"{result}");
        }
    }
}
