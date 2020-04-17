using System;
namespace HackerRank_Playground.Exceptions
{
    public static class StringToInt
    {
        public static void ConvertStringToInt(string s)
        {
            try
            {
                int convertedString = Convert.ToInt32(s);
            }
            catch (Exception ex)
            {
                throw new Exception("Bad String");
            }
        }
    }
}
