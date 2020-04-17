using System;
using HackerRank_Playground.Exceptions;
using HackerRank_Playground.LinkedList;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number");
            string S = Console.ReadLine();
            StringToInt.ConvertStringToInt(S);
        }
    }
}
