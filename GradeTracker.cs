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
            GradeTracker gradeTracker = new GradeTracker(); // Create an instance of the GradeTracker  
            Console.WriteLine("Welcome to Sabra's Grade Tracker!"); // Display welcome message  
            Console.WriteLine("You will be prompted to enter 5 grades."); // Prompt user for grades  
            try {
                CreateArray(); // Call the method to create the grades array of 5 grades  
                GetGradesFromUser(grades); // Call the method to get grades from the user  
                PrintReport(); // Call the method to print the report of grades  
                GetHighestGrade(); // Call the method to get the highest grade
                double average = CalculateAverage(); // Store the average grade in a variable for further use  
                string letterGrade = gradeTracker.GetLetterGrade(average); // Call the method to get the letter grade for display purposes  
                Console.WriteLine($"\nThe letter grade is: {letterGrade}"); // Display the letter grade  
            }   
            catch (Exception ex) // Catch any exceptions that may occur during execution
            {
                Console.WriteLine($"An error occurred: {ex.Message}"); // Display the error message
            }
            finally
            {
                Console.WriteLine("Thank you for using Sabra's Grade Tracker!"); // Display a thank you message
            }
        }
        public void CreateArray()
        {
            grades = new Grade[MaxGrades]; // Initialize the grades array with a size of MaxGrades
        }

        public static void GetGradesFromUser(Grade[] grades)
        {
            try
            { 
                for (int i = 0; i < MaxGrades; i++)
                {
                    Console.Write($"Enter Grade #{i + 1}: "); //prompt user for grade input
                    double grade = 0; // Initialize grade to 0
                    if ((!Double.TryParse(Console.ReadLine(), out grade))|| grade < 0 || grade > 100) //Validate user input is a number
                    {
                        Console.WriteLine($" Grade#{i + 1} must be a number 0-100. Please re-enter: ");
                    }
                    else
                    {
                        grades[i] = new Grade(grade);  // Check if the grade is within the valid range (0-100)
                    }  
                }
            }
            catch (ArgumentNullException ex) // Catch null reference exceptions that may occur during input
            {
                Console.WriteLine($"Input cannot be null: {ex.Message}. Please enter a valid number."); // Display the error message
            }
            catch (FormatException ex) // Catch format exceptions that may occur during input
            {
                Console.WriteLine($"Invalid input: {ex.Message}. Please enter a valid number."); // Display the error message
            }
            catch (Exception ex) // Catch any exceptions that may occur during input
            {
                Console.WriteLine($"An error occurred while entering grades: {ex.Message}"); // Display the error message
            }
            finally
            {
                Console.WriteLine("Grades have been successfully entered."); // Display a success message after entering grades
            }
        }









        public void PrintReport()
        {
            Console.WriteLine("\n=====   Sabra's Grades Report   =====");
            Console.Write("\nAll Grades ");

            foreach (var grade in grades) // Iterate through each grade in the grades array
            {
                for (int i = 0; i < MaxGrades; i++)// Loop through the grades array
                {
                    Console.Write($"-{i + 1}: {grade}% "); // Print each grade
                }
            }

        }
        public double CalculateAverage()
        {
            double total = 0;

            foreach (var grade in grades)
            {
                total += grade.grade; // Access the 'grade' property of the 'Grade' object correctly  
            }
            double average = total / MaxGrades; // Calculate the average.  
            Console.WriteLine($"\nThe final grade is: {average}"); // Display the average grade  
            return average; // Return the calculated average  
        }

        public string GetLetterGrade(double average)
        {
            string letterGrade; // Declare a variable to hold the letter grade
            switch (average / 10) // Integer division for grouping into 10-point ranges
            {
                //* Using switch statement to determine the letter grade *

                case 10:
                case 9:
                    letterGrade = "A"; // Return "A" for averages 90 and above
                    break;
                case 8:
                    letterGrade = "B"; // Return "B" for averages between 80 and 89
                    break;
                case 7:
                    letterGrade = "C"; // Return "C" for averages between 70 and 79
                    break;
                case 6:
                    letterGrade = "D"; // Return "D" for averages between 60 and 69
                    break;
                default:
                    letterGrade = "F"; // Return "F" for averages below 60
                    break;
            } return letterGrade; // Return the letter grade based on the average
        }
        private void GetHighestGrade()
        {
            var highestGrade = grades.OrderByDescending(g => g.grade).First();

            Console.WriteLine($"The highest grade was {highestGrade}%");
        }
    }
}







