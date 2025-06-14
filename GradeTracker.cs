using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Week6_GradeTracker
{
    public class GradeTracker
    {
        
        private const int MaxGrades = 5; // Maximum number of grades allowed

        private Grade[]? grades;  //initialize the grades array to hold up to 5 grades
        
        public record Grade(double percentageGrade, string letterGrade)
        {
            private readonly double PercentageGrade = percentageGrade; // Property to hold the percentage grade
            public string LetterGrade { get; } = letterGrade; // Property to hold the letter grade
            public override string ToString() => $"{PercentageGrade} - {LetterGrade}"; // Override ToString method for easy display
        }
        
        private void CreateArray()
        {
            grades = new Grade[MaxGrades]; // Initialize the grades array with a size of MaxGrades
        }

        public static Grade GetGradesFromUser(out Grade[] grades)
        {
             
             
            Console.WriteLine("Enter 5 numeric grades from 0-100 to be averaged and converted to a letter grade.\n" +
                              "Press Enter after each grade to continue. Press Enter again to stop.\n");
            
            for (int i = 0; i < MaxGrades; i++)
            {
                Console.Write($"Enter Grade #{i + 1}: ");
                
                while (double.IsNaN(gradeEntered) || gradeEntered < 0 || gradeEntered > 100 )
                {
                    Console.Write($"Grade is not valid. Enter a whole number between 1 and 100 for Grade #{i+1}: ");
                    gradeEntered = Console.ReadLine();
                }
                Console.Write("Enter percentage grade as a whole number (0-100): ");
                double grade;
                while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid input. Grade must be a whole number between 0 and 100.");
                    Console.Write("Enter valid percentage grade: ");
                }
                double gradeEntered = (double)Console.ReadLine(); // Create a new Grade object with the entered values

                Console.WriteLine(); // Fix: Use the object reference to call the instance method ToString()  
                
                
            }

            // Fix: Return the first grade entered or null if no grades were entered  
            return gradeBook[0] ?? new Grade("", 0);
        }
        public static double CalculateAverage(double[] grades)
        {
            if (grades == null || grades.Length == 0)
            {
                return 0; // Return 0 if the array is null or empty.  
            }
            int count = 0; // Initialize count to track the number of valid grades.
            double total = 0;
            double average; // Initialize average to 0.

            foreach (var grade in grades)
            {
                if (grade >= 0) // Check for valid non-negative grades.  
                {
                    total += grade;
                    count++;
                }
            }
            average = total / count; // Calculate the average.
            return count > 0 ? average : 0; // Return average or 0 if no valid grades.  
        }

        //public static void CalculateAverage(Grade[] gradebook, int Count)
        //{
        //    int gradeSum = 0;
        //    int gradeAverage = 0;
        //    string letterGrade = "";
        //    for (int i = 0; i < 6; i++)
        //    {
        //        if (gradebook[i] != null)
        //        {
        //            gradeSum += gradebook[i].PercentageGrade;
        //            gradeAverage = (gradeSum / Count);
        //            letterGrade = (GetLetterGrade(gradeAverage));
        //            Console.WriteLine($"The average grade is: {gradeAverage} , {letterGrade}.");
        //        }
        //    }
        //}

        //double total = 0; // Initialize total to 0
        //int count = 0; // Initialize count to track the number of grades

        //for (int i = 0; i < grades.Length; i++) // Iterate through the outer array
        //{
        //    if (grades[i] != null && grades[i].Length > 0) // Ensure the inner array is not null or empty
        //    {
        //        for (int j = 0; j < grades[i].Length; j++) // Iterate through the inner array
        //        {
        //            if (grades[i][j] >= 0) // Check if the grade is a valid non-negative number
        //            {
        //                total += grades[i][j]; // Sum up the grades in the inner array
        //                count++; // Increment count for each grade
        //            }
        //        }
        //    }
        //}

        public static string GetLetterGrade(double grade)
        {
            
            switch (grade / 10) // Integer division for grouping into 10-point ranges
            {   
                //* Using switch statement to determine the letter grade *

                case 10:
                case 9:
                    return "A"; // Return "A" for averages 90 and above
                case 8:
                    return "B"; // Return "B" for averages between 80 and 89
                case 7:
                    return "C"; // Return "C" for averages between 70 and 79
                case 6:
                    return "D"; // Return "D" for averages between 60 and 69
                default:
                    return "F"; // Return "F" for averages below 60
            }

            //  *Using if statements to determine the letter grade*

            //  if (grade >= 90)  
            //  {
            //      return "A"; // Return "A" for averages 90 and above
            //  }
            //  else if (grade >= 80)
            //  {
            //      return "B"; // Return "B" for averages between 80 and 89
            //  }
            //  else if (grade    >= 70)
            //  {
            //      return "C"; // Return "C" for averages between 70 and 79
            //  }
            //  else if (grade >= 60)
            //  {
            //      return "D"; // Return "D" for averages between 60 and 69
            //  }
            //  else
            //  {
            //      return "F"; // Return "F" for averages below 60
            //  }
        }
        //public static void DisplayMenu()
        //{
        //    Console.WriteLine("\n======= Sabra's Gradebook =======");
        //    Console.WriteLine("\n     1. Enter new grade.");
        //    Console.WriteLine("     2. Exit Application.");
        //    Console.WriteLine("\n=================================");
        //    Console.WriteLine();
        //}
        //public static int GetUserChoice()
        //{
        //    Console.Write("Enter your choice: ");

        //    if (int.TryParse(Console.ReadLine(), out int choice))
        //    {
        //        Console.WriteLine();
        //        return choice;
        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please Select 1 or 2.");
        //        return 0; // Return a default value indicating invalid input  
        //    }
        //}

        //public static void ChoiceHandler(Grade[] grades)
        //{
        //    while (true) // Infinite loop to keep displaying the menu until the user chooses to exit 
        //    {
        //        GradeTracker.DisplayMenu(); // Display the menu each time the loop starts
        //        int choice;

        //        do
        //        {
        //             // Initialize the gradebook array with a size of 5
        //            choice = GetUserChoice();
        //            Console.WriteLine("You selected: " + choice);
        //            if (choice != 1 && choice != 2)
        //            {
        //                Console.WriteLine("Invalid choice. Please select 1 or 2: ");
        //                continue; // If the choice is not valid, prompt the user again
        //            }
        //            else
        //            {
        //                switch (choice)
        //                {
        //                    case 1:
        //                        while (gradebook.Length < 5)
        //                        {
        //                            for (int i = 0; i < 4; i++)
        //                            {
        //                                gradeBook[i] = GetGradesFromUser();

        //                            }
        //                        }
        //                        break;
        //                    case 2:
        //                        break;
        //                    default:
        //                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
        //                        break;
        //                }
        //            }
        //        }
        //        while (choice != 2); // Continue looping until the user chooses to exit
        //    }
        //}
        public static void PrintReport(Grade[] grades)
        {
            for (int i = 0; i < 5; i++)
            {
                if (grades[i] != null)
                {
                    Console.WriteLine(grades[i].ToString());
                }
            }
        }
        
    }
}







