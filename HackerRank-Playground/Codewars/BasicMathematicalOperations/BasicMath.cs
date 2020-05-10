using System;
namespace HackerRank_Playground.Codewars.BasicMathematicalOperations
{
    public static class BasicMath
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
                default:
                    throw new InvalidOperationException();
            }
        }   
    }
}
