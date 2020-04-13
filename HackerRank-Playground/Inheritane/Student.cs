using System;
namespace HackerRank_Playground.Inheritane
{
    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] testScores)
            : base(firstName, lastName, id)
        {
            this.testScores = testScores;
        }

        public char Calculate()
        {
            int sumary = 0;
            foreach (var grade in testScores)
            {
                sumary += grade;
            }

            var averageGrade = sumary / testScores.Length;
            char gradeChar;

            if ((averageGrade >= 90) && (averageGrade <= 100))
            {
                gradeChar = 'O';
            }
            else if ((averageGrade >= 80) && (averageGrade < 90))
            {
                gradeChar = 'E';
            }
            else if ((averageGrade >= 70) && (averageGrade < 80))
            {
                gradeChar = 'A';
            }
            else if ((averageGrade >= 55) && (averageGrade < 70))
            {
                gradeChar = 'P';
            }
            else if ((averageGrade >= 40) && (averageGrade < 55))
            {
                gradeChar = 'D';
            }
            else
            {
                gradeChar = 'T';
            }

            return gradeChar;
        }
    }
}
