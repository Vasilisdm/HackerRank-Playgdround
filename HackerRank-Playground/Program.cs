using System;
using HackerRank_Playground.Interface;
using HackerRank_Playground.Interfaces;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
