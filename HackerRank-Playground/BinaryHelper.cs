using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Playground
{
    public static class BinaryHelper
    {
        public static int FindConsecutiveOnesInBinary(int n)
        {
            string binaryForm = "";
            string consecutiveOnesArray = "";
            int consecutinveOnesCounter = 0;

            while (n > 0)
            {
                int remainder = n % 2;

                n /= 2;

                binaryForm += remainder;
            }

            string[] digitsArray = binaryForm.Split("0");

            for (int i = 0; i < digitsArray.Count(); i++)
            {
                if (consecutinveOnesCounter < digitsArray[i].Count())
                {
                    consecutiveOnesArray = digitsArray[i];
                    consecutinveOnesCounter = digitsArray[i].Count();
                };
            }

            return consecutiveOnesArray.Count();
        }
    }
}
