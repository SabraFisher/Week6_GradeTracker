﻿using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week6_GradeTracker
{
    public static class Program
    {
        static void Main()
        {
            GradeTracker gradeTracker = new GradeTracker(); // Create an instance of the GradeTracker  

            gradeTracker.Run(); // Call the Run method to start the grade tracking process        }
        }
    }
}
