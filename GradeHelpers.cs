using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week6_GradeTracker
{
    public static class GradeHelpers
    {
        


        //public static void Run()
        //{
        //    DisplayMenu();
        //    GetUserChoice();
        //    ChoiceHandler();
        //}

        public static void DisplayMenu()
        {
            Console.WriteLine("\n======= Sabra's Gradebook =======");
            Console.WriteLine("\n     1. Enter new grade.");
            Console.WriteLine("     2. Exit Application.");
            Console.WriteLine("\n=================================");
            Console.WriteLine();
        }
        public static int GetUserChoice()
        {
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine();
                return result;
            }

            else
            {
                Console.WriteLine("Invalid input. Please Select 1 or 2.");
                return 0; // Return a default value indicating invalid input  
            }
        }

        public static void ChoiceHandler(Grade[] gradebook, int Count)
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = GetUserChoice();

                switch (choice)
                {
                    case 1:
                        if (gradebook.Length < 5)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                Console.WriteLine($"Enter grade {i + 1}:");
                                gradebook[i] = GetGradesFromUser();
                            }
                        }
                        PrintReport(gradebook);
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
                        break;
                }
            }
            while (choice != 2);  // Exit the loop when the user chooses option 2  
        }  


        public static Grade GetGradesFromUser()
        {
            Console.WriteLine($"Please enter the information for Student and Grade below");
            Console.Write("Name of Student: ");
            string? name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Enter name: ");
                name = Console.ReadLine();
            }

            int percentageGrade;
            Console.WriteLine("Enter grade as a whole number percentage: ");
            while (!int.TryParse(Console.ReadLine(), out percentageGrade))
            {
                Console.WriteLine("Invalid. Enter Percentage Grade: ");
                percentageGrade = int.Parse(Console.ReadLine());
            }
            while (percentageGrade < 0 || percentageGrade > 100)
            {
                Console.WriteLine("Percentage Grade must be whole number between 0 and 100.");
                Console.WriteLine("Enter Percentage Grade: ");
                percentageGrade = int.Parse(Console.ReadLine());
            }
            
            return new Grade(name!, percentageGrade);
        }
        public static void DisplayAllStudents(Grade[] gradeBook)
        {
            Console.WriteLine("\n-- All Enrolled Students --");
            for (int i = 0; i < gradeBook.Length; i++)
            {
                Console.WriteLine($"Name: {gradeBook[i].Name}, Percentage Grade: {gradeBook[i].PercentageGrade}");
            }
        }

              
        public static void CalculateAverage(Grade[] gradebook, int Count)
        {
            int gradeSum = 0;
            int gradeAverage = 0;
            
            for (int i = 0; i < 6; i++)
            {
                if (gradebook[i] != null)
                {
                    gradeSum += gradebook[i].PercentageGrade;
                    gradeAverage = (gradeSum / Count);
                    Console.WriteLine($"The average grade is: {gradeAverage}");
                }
            }
        }

       
        
        public static void PrintReport(Grade[] gradebook)
        {
            
        }
    }
}
