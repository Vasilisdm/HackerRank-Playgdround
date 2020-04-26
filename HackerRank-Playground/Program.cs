using System;
using HackerRank_Playground.Complexity;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var t = Get(); t > 0; --t)
            {
                Console.WriteLine(Prime.IsPrime(Get()) ? "Prime" : "Not prime");
            }
        }

        public static int Get() => int.Parse(Console.ReadLine());
    }
}
