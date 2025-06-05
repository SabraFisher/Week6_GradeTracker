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
    public static class GradeHelpers
    {
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
                GetUserChoice();
                choice = GetUserChoice();
                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Invalid choice. Please select 1 or 2: ");
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            if (gradebook.Length < 5)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    gradebook[5] = GetGradesFromUser();
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
            }
            while (choice != 2);  // Exit the loop when the user chooses option 2  
        }

        public static void PrintReport(Grade[] gradebook)
        {
            for (int i = 0; i < 5; i++)
            {
                if (gradebook[i] != null)
                {
                    Console.WriteLine(gradebook[i].ToString());
                }
            }
        }
        public static Grade GetGradesFromUser()
        {
            int count = 0; // Initialize count to track the number of grades entered  
            Grade[] gradeBook = new Grade[5]; // Initialize the gradebook array with a size of 5  
            Console.WriteLine("Enter the name and percentage grade for each student (up to 5 students):");
            for (int i = 0; i < 5; i++)
            {
                count++;
                Console.Write($"Enter the name of the student for grade number {i + 1}: ");
                string? name = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.Write("Name cannot be empty. Enter name: ");
                    name = Console.ReadLine();
                }
                Console.Write("Enter percentage grade as a whole number (0-100): ");
                int percentageGrade;
                while (!int.TryParse(Console.ReadLine(), out percentageGrade) || percentageGrade < 0 || percentageGrade > 100)
                {
                    Console.WriteLine("Invalid input. Percentage grade must be a whole number between 0 and 100.");
                    Console.Write("Enter valid percentage grade: ");
                }
                gradeBook[i] = new Grade(name, percentageGrade);
                Console.WriteLine(gradeBook[i].ToString()); // Fix: Use the object reference to call the instance method ToString()  

                if (count >= 5)
                {
                    Console.WriteLine("You have reached the maximum number of grades (5).");
                    break; // Exit the loop if the maximum number of grades is reached  
                }
            }

            // Fix: Return the first grade entered or null if no grades were entered  
            return gradeBook[0] ?? new Grade("", 0);
        }
    }
}







