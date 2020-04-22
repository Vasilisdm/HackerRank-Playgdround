using System;
namespace HackerRank_Playground.BubbleSort
{
    public static class Bbl
    {
        public static void BblSort(int[] a)
        {
            int n = a.Length;
            int totalSwaps = 0;
            for (int i = n - 1; i > 0; i--)
            {
                int numberOfSwaps = 0;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numberOfSwaps++;
                        totalSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Array is sorted in " + totalSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[n - 1]);
        }
    }
}
