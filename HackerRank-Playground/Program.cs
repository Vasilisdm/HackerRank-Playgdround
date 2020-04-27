using System;
using HackerRank_Playground.GregorianCalendar;
using HackerRank_Playground.WarmUP;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedString.AOccurances(s, n);

            Console.WriteLine(result);
        }
    }
}
