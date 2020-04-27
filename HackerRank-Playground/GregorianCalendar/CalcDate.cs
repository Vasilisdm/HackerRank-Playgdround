using System;
namespace HackerRank_Playground.GregorianCalendar
{
    public static class CalcDate
    {
        public static int DateDifference(int[] returnedDate, int[] dueDate)
        {
            int fine = 0;

            if (returnedDate[2] > dueDate[2])
            {
                fine = 10000;
            }
            else if (returnedDate[1] > dueDate[1] && returnedDate[2] == dueDate[2])
            {
                fine = 500 * (returnedDate[1] - dueDate[1]);
            }
            else if (returnedDate[0] > dueDate[0] && returnedDate[1] == dueDate[1] && returnedDate[2] == dueDate[2])
            {
                fine = 15 * (returnedDate[0] - dueDate[0]);
            }
            else if (returnedDate[0] <= dueDate[0] && returnedDate[1] <= dueDate[1] && returnedDate[2] <= dueDate[2])
            {
                fine = 0;
            }

            return fine;
        }
    }
}
