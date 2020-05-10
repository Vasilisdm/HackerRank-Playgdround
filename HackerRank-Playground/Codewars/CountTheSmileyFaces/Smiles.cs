using System;
using System.Text.RegularExpressions;

namespace HackerRank_Playground.Codewars.CountTheSmileyFaces
{
    public static class Smiles
    {
        public static int CountSmileys(string[] smileys)
        {
            int totalSmileys = 0;

            if (smileys.Length == 0)
            {
                return 0;
            }

            Regex smiley1 = new Regex(":\\)");
            Regex smiley2 = new Regex(";\\)");

            Regex smiley3 = new Regex(":D");
            Regex smiley4 = new Regex(";D");

            Regex smiley5 = new Regex(";-D");
            Regex smiley6 = new Regex(";~D");
            Regex smiley7 = new Regex(":~D");
            Regex smiley8 = new Regex(":-D");

            Regex smiley9 = new Regex(":~\\)");
            Regex smiley10 = new Regex(";~\\)");

            Regex smiley11 = new Regex(":-\\)");
            Regex smiley12 = new Regex(";-\\)");

            foreach (var str in smileys)
            {
                MatchCollection smiley1Matches = smiley1.Matches(str);
                MatchCollection smiley2Matches = smiley2.Matches(str);
                MatchCollection smiley3Matches = smiley3.Matches(str);
                MatchCollection smiley4Matches = smiley4.Matches(str);
                MatchCollection smiley5Matches = smiley5.Matches(str);
                MatchCollection smiley6Matches = smiley6.Matches(str);
                MatchCollection smiley7Matches = smiley7.Matches(str);
                MatchCollection smiley8Matches = smiley8.Matches(str);
                MatchCollection smiley9Matches = smiley9.Matches(str);
                MatchCollection smiley10Matches = smiley10.Matches(str);
                MatchCollection smiley11Matches = smiley11.Matches(str);
                MatchCollection smiley12Matches = smiley12.Matches(str);

                totalSmileys += smiley1Matches.Count +
                                smiley2Matches.Count +
                                smiley3Matches.Count +
                                smiley4Matches.Count +
                                smiley5Matches.Count +
                                smiley6Matches.Count +
                                smiley7Matches.Count +
                                smiley8Matches.Count +
                                smiley9Matches.Count +
                                smiley10Matches.Count +
                                smiley11Matches.Count +
                                smiley12Matches.Count;
             }

            return totalSmileys;
        }
    }
}
