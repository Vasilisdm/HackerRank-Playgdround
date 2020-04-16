using System;
using System.Linq;
using HackerRank_Playground.Garage;
using HackerRank_Playground.Scope;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] res = ArrayHelpers.reverseArray(arr);

            foreach (var number in res)
            {
                Console.Write(number);
            }
        }
    }
}
