using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HackerRank_Playground.GregorianCalendar;
using HackerRank_Playground.WarmUP;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(String[] args)
        {

        }


        public List<string> reorderLines(int logFileSize, string[] logLines)
        {
            List<string> orderedLogLines = new List<string>();

            for (int i = 0; i < logFileSize - 1; i++)
            {
                if (isAlphaNumeric(logLines[i]))
                {
                    orderedLogLines.Add(logLines[i]);
                }
            }

            orderedLogLines.Sort();

            return orderedLogLines;
        }

        public static Boolean isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(strToCheck);
        }
    }
}
