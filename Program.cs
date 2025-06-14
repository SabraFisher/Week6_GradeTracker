using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week6_GradeTracker
{
    public static class Program
    {
        static void Main()
        {

            int count; // Initialize count to track the number of grades
            int size = 5; // Set the size of the grade array
            Grade[] grades = new Grade[size]; // Initialize the gradebook array with a size of 5
            Console.WriteLine("Enter the name and percentage grade for each student (up to 5 students):");
            // Get grades from the user
            GradeTracker.GetGradesFromUser(out grades, count);
            
            GradeTracker.CalculateAverage(grades, count);


            // 1. Create a list of grades
            // 2. Calculate the sum of all grades (inside CalculateAverage method)
            // 3. Divide by the number of grades to get the average (inside CalculateAverage method)
            // 4. Determine the letter grade based on the average (inside GetLetterGrade method)
            // 5. Output the average and letter grade to the console (inside Main method here but should have interface.))

            ////var grades = new List<double> { 88, 92, 76, 81, 95 };
            //Array[double] grades;
            //var average = GradeTracker.CalculateAverage(grades);
            //var letter = GradeTracker.GetLetterGrade(average);

            //Console.WriteLine($"Average: {average:F2}, Grade: {letter}");

        }
    }
}
