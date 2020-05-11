using System;
using HackerRank_Playground.Codewars.VasyaClerk;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(String[] args)
        {
            var isAbleToGiveChange = Line.Tickets(new int[] { 25, 100 });
            Console.WriteLine(isAbleToGiveChange);
        }
    }
}