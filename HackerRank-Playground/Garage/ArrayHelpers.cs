using System;
namespace HackerRank_Playground.Garage
{
    public static class ArrayHelpers
    {
        public static int[] reverseArray(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                reversedArr[j++] = arr[i];
            }

            return reversedArr;
        }
    }
}
