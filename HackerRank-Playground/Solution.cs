using System;
namespace HackerRank_Playground
{
    public static class Solution
    {
        public static void evenOddChars(int numberOfStrings)
        {
            string[] wordsArray = new string[numberOfStrings];
            
            for (int i = 0; i < numberOfStrings; i++)
            {
                wordsArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < wordsArray.Length; i++)
            {
                var word = wordsArray[i];
                var evenString = "";
                var oddString = "";

                for (int j = 0; j < word.Length; j++)
                {
                    if (j%2==0)
                    {
                        evenString += word[j];
                    }
                    else
                    {
                        oddString += word[j];
                    }
                }
                Console.WriteLine($"{evenString} {oddString}\r");
            }
        }        
    }
}
