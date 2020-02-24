using System;
using System.Collections.Generic;

namespace GradeBook
{    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Hudas Grades");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(95.3);
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N2}"); 
        }
    }
}
