using System;
using HackerRank_Playground.BubbleSort;
using HackerRank_Playground.Generics;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}

			GenericArray<int>.PrintArray<Int32>(intArray);
			GenericArray<string>.PrintArray<string>(stringArray);
		}
    }
}
