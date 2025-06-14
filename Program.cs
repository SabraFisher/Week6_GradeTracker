using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week6_GradeTracker
{
    public static class Program
    {
        static void Main()
        {
            // 1. Create a list of grades
            // 2. Calculate the sum of all grades (inside CalculateAverage method)
            // 3. Divide by the number of grades to get the average (inside CalculateAverage method)
            // 4. Determine the letter grade based on the average (inside GetLetterGrade method)
            // 5. Output the average and letter grade to the console (inside Main method here but should have interface.))

            //var grades = new List<double> { 88, 92, 76, 81, 95 };
            var grades = new List<double>();
            var average = GradeTracker.CalculateAverage(grades);
            var letter = GradeTracker.GetLetterGrade(average);

            Console.WriteLine($"Average: {average:F2}, Grade: {letter}");


            //Grade[]? gradeBook = null;
            //int Count =0;
            //GradeTracker.DisplayMenu();
            //GradeTracker.GetUserChoice();
            //GradeTracker.ChoiceHandler(gradeBook!);
            //Grade.CalculateAverage(gradeBook!, Count);

        }
    }
}
