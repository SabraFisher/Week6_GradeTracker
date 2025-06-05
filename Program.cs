using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week6_GradeTracker
{
    public static class Program
    {
        public static void Main()
        {
            Grade[] gradeBook = new Grade[5];
            int Count = 0;
            

            GradeHelpers.DisplayMenu();
            GradeHelpers.GetUserChoice();
            GradeHelpers.ChoiceHandler(gradeBook,  Count);
            GradeHelpers.GetGradesFromUser();
            GradeHelpers.CalculateAverage(gradeBook, Count);
           
            GradeHelpers.PrintReport();
        }
    }
}
