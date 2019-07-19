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

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
            
            var stats = book.GetStats();
            Console.WriteLine($"For the book named {book.Name}:");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average letter grade is {stats.Letter}");
        }
    }
}
