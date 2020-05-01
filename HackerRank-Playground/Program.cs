using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HackerRank_Playground.GregorianCalendar;
using HackerRank_Playground.WarmUP;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Regex rx = new Regex(@"@gmail\.com$");

            List<string> namesList = new List<string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];
                
                string emailID = firstNameEmailID[1];

                Match match = rx.Match(emailID);
                if (match.Success)
                {
                    namesList.Add(firstName);
                }
            }

            namesList.Sort();
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
