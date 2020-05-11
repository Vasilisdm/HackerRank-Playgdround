using System;
namespace HackerRank_Playground.Codewars.VasyaClerk
{ 
    public static class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            int wallet25 = 0;
            int wallet50 = 0;
            int wallet100 = 0;

            if (peopleInLine[0] > 25)
            {
                return "NO";
            }

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25)
                {
                    wallet25 += 1; 
                }
                else if (peopleInLine[i] == 50 && wallet25 > 0)
                {
                    wallet50 += 1;
                    wallet25 -= 1;
                }
                else if (peopleInLine[i] == 100 && wallet25 > 0 && wallet50 > 0)
                {
                    wallet100 += 1;
                    wallet50 -= 1;
                    wallet50 -= 1;
                }
                else if (peopleInLine[i] ==100 && wallet25 > 2)
                {
                    wallet100 += 1;
                    wallet25 -= 3;
                }
                else
                {
                    return "NO";
                }
            }

            return "YES";
        }
    }
}
