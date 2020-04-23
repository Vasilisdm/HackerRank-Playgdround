using System;
namespace HackerRank_Playground.Generics
{
    public static class GenericArray<T>
    {
        public static void PrintArray<T>(T[] arr)
        {
            foreach (T element in arr)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
