using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week6_GradeTracker
{
    public static class Program
    {
        public static void Main()
        {
            Grade[] gradeBook = new Grade[5];
            int count = 0;
            

            GradeHelpers.DisplayMenu();
            GradeHelpers.GetGradesFromUser();
            GradeHelpers.CalculateAverage(gradeBook);
            GradeHelpers.GetLetterGrade(Grade.percentageGrade);
            GradeHelpers.PrintReport();
        }
    }
}
