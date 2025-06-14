using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week6_GradeTracker
{
    public static class Program
    {
        public static void Main()
        {
            Grade[]? gradeBook = null;
            int Count =0;
            GradeTracker.DisplayMenu();
            GradeTracker.GetUserChoice();
            GradeTracker.ChoiceHandler(gradeBook!);
            Grade.CalculateAverage(gradeBook!, Count);
        }
    }
}
