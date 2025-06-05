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

                switch (choice)
                {
                    case 1:
                        if (gradebook.Length < 5)
                        {
                            for (int i = 0; i < 6; i++)
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
        public static Array[] GetGradesFromUser()
        {
            Grade[] gradeBook =  new Grade[5]; // Initialize the gradebook array with a size of 5
             // Create a new Grade object with default values
            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine("Enter the name and percentage grade for each student (up to 5 students):");

                Console.Write($"Enter the name of the student for grade number {i + 1}: ");
                string? name = "";
                if (!string.IsNullOrWhiteSpace(name))
                {
                    name = Console.ReadLine();
                }
                else while (string.IsNullOrWhiteSpace(name))
                    {
                        Console.Write("Name cannot be empty. Enter name: ");
                        name = Console.ReadLine();
                    }

                Console.Write("Enter percentage grade as a whole number (0-100): ");
                int percentageGrade = 0;
                while (!int.TryParse(Console.ReadLine(), out percentageGrade))
                {

                    Console.WriteLine("Invalid input. Percentage grade must be a whole number between 0 and 100.");
                    Console.Write("Enter valid percentage grade: ");
                    // Ensure we read a valid integer input
                }
                while (percentageGrade < 0 || percentageGrade > 100)
                {
                    Console.WriteLine("Percentage grade must be a whole number between 0 and 100.");
                    Console.Write("Enter valid percentage grade: ");
                    percentageGrade = int.Parse(Console.ReadLine()!); // Ensure we read a valid integer input
                }


                Grade gradeBook[i] = new Grade(name, percentageGrade)};
            
             
        }

        //{
        //    int i = 0;
        //    for (i = 0; i < 6; i++)
        //    {
        //        Grade grade = new Grade("", 0);
        //        Grade[] gradeBook = new Grade[i + 1];
        //        Console.Write($"Name of Student{i + 1}: ");
        //        string? name[] = Console.ReadLine();
        //        while (string.IsNullOrWhiteSpace(name))
        //        {
        //            Console.Write("Name cannot be empty. Enter name: ");
        //            name = Console.ReadLine();
        //        }

        //        Console.WriteLine("Enter percentage grade as a whole number 0-100: ");
        //        int percentageGrade = 0;
        //        while (!int.TryParse(Console.ReadLine(), out percentageGrade))
        //        {
        //            Console.WriteLine("Invalid. Enter Percentage Grade: ");
        //        }
        //        while (percentageGrade < 0 || percentageGrade > 100)
        //        {
        //            Console.WriteLine("Percentage Grade must be a whole number between 0 and 100.");
        //            Console.WriteLine("Enter Percentage Grade: ");
        //            percentageGrade = int.Parse(Console.ReadLine()!);
        //        }


        //        gradeBook[i] = new Grade(name, percentageGrade);

        //        if (i >= 6)
        //        {
        //            Console.WriteLine("Gradebook is full. No more grades can be added.");
        //            return gradeBook;
        //        }
        //        else
        //        {
        //            return gradeBook; // Return the filled gradebook array
        //        }

    }
}


      
