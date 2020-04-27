using System;
using HackerRank_Playground.GregorianCalendar;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] returnedDate = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] dueDate = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));


            Console.WriteLine(CalcDate.DateDifference(returnedDate, dueDate));


        }

        
    }
}
