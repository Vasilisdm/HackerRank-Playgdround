using System;
using HackerRank_Playground.BubbleSort;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            BubbleSort.Bbl.BblSort(a);
        }
    }
}
