// See https://aka.ms/new-console-template for more information


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ruth's Grade Book");
            book.AddGrade(89.1);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The sum is: {stats.Average}");
            Console.WriteLine($"The average is: {stats.Average:N1}");
            Console.WriteLine($"The highest grade is: {stats.High:N1}");
            Console.WriteLine($"The lowest grade is: {stats.Low:N1}");
        }
     }
}

