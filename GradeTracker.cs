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
        
        public record Grade(double grade);
        
        public void Run()
        {
            CreateArray(); // Call the method to create the grades array of 5 grades
            GetGradesFromUser(); // Call the method to get grades from the user
            CalculateAverage(); // Call the method to calculate the average of the grades
            GetLetterGrade(); // Call the method to get the letter grade based on the average
            PrintReport(); // Call the method to print the report of grades
        }

        private void CreateArray()
        {
            grades = new Grade[MaxGrades]; // Initialize the grades array with a size of MaxGrades
        }

        public void GetGradesFromUser()
        {
            for (int i = 0; i < MaxGrades; i++)
            {
                Console.Write($"Enter Grade #{i + 1}: "); //prompt user for grade input
                double grade = 0; // Initialize grade to 0
                while (!Double.TryParse(Console.ReadLine(), out grade)) //Validate user input is a number
                {
                    Console.WriteLine($" Grade#{i + 1} must be a number 0-100. Please re-enter: ");
                }
                grades[i] = new Grade(grade); // Store the grade in the grades array at index i 
            }
        }
        public void CalculateAverage()
        {
            double total = 0;

            foreach (var grade in grades)
            {
                total += grade.grade; // Access the 'grade' property of the 'Grade' object correctly  
            }
            double average = total / MaxGrades; // Calculate the average.  
            Console.Write($"The final grade is: {average}"); // Display the average grade
        }

        

        

        public void GetLetterGrade()
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
   

        public static void PrintReport()
        {
            Console.WriteLine("\n=====   Sabra's Grades Report   =====");
            Console.WriteLine("All Grades: ");

            foreach (var grade in grades) // Iterate through each grade in the grades array
            {
                for (int i = 0; i < MaxGrades; i++)// Loop through the grades array
                {
                    Console.WriteLine($"Grades: {grade}"); // Print each grade
                
            }
        }
        
    }
}







