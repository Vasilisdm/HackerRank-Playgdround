using System;
using System.Linq;
using HackerRank_Playground.Scope;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Insert the number of elements");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the each element:");
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write($"The maximum difference between 2 elements is {d.maximumDifference}");
        }
    }
}
