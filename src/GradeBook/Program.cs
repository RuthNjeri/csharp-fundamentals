// See https://aka.ms/new-console-template for more information


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ruth's Grade Book");
            book.AddGrade(89.1);
            book.ShowStatistics();
        }
     }
}

