using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Playground.Codewars.ArrayDiff
{
    public class ArrayDiff
    {
        public static int[] ElementSubtraction(int[] a, int[] b)
        {
            int[] matchedNumbers = Array.FindAll(a, numberInA => b.Contains(numberInA));

            var notCommonNumbers = (from number in a
                                    where !matchedNumbers.Contains(number)
                                    select number).ToArray();
            
            return notCommonNumbers;
        }
    }
}
