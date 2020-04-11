using System;
using System.Collections.Generic;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to be converted to binary.");

            int numberToBeBinary = Convert.ToInt32(Console.ReadLine());

            var consecutiveOnes = BinaryHelper.FindConsecutiveOnesInBinary(numberToBeBinary);

            Console.WriteLine($"Consecutive ones of binary conversion are:{consecutiveOnes}");
        }
    }
}
