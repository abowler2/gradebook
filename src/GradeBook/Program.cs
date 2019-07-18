using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade Book");
            
            while (true)
            {
                Console.WriteLine("Please enter grade: (press 'q' when done)");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                
                var grade = double.Parse(input);
                book.AddGrade(grade);
            } 
            
            var stats = book.GetStats();
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average letter grade is {stats.Letter}");
        }
    }
}
