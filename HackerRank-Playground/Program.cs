using System;
using HackerRank_Playground.Codewars.CountTheSmileyFaces;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(String[] args)
        {
            var str = new string[] { ":D", ":~)", ";~D", ":)" };
            Console.WriteLine($"{Smiles.CountSmileys(str)}");
        }
    }
}
