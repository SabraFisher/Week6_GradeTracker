using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_GradeTracker
{
    public record Grade() //string? Name, int PercentageGrade)
    {
         // double to allow for decimal grades
        //public string? LetterGrade { get; set; }
        //public static string GetLetterGrade(int percentageGrade)
        //{
        //    string letterGrade = "";
        //    switch (percentageGrade / 10) // Integer division for grouping into 10-point ranges
        //    {
        //        case 10:
        //        case 9:
        //            letterGrade = "A";
        //            return letterGrade;
        //        case 8:
        //            letterGrade = "B";
        //            return letterGrade;
        //        case 7:
        //            letterGrade = "C";
        //            return letterGrade;
        //        case 6:
        //            letterGrade = "D";
        //            return letterGrade;
        //        default:
        //            letterGrade = "F";
        //            return letterGrade;
        //    }
        //}
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
        //public override string ToString()
        //{
        //    return $"{Name}: {PercentageGrade}% ({GetLetterGrade(PercentageGrade)})";
        //}
    }

}
