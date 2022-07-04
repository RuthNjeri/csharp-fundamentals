// See https://aka.ms/new-console-template for more information


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ruth's Grade Book");
            book.AddGrade(89.1);


            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            var result = 0.0;

            //List<double> grades = new List<double>();
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            foreach(double number in grades)//numbers
            {
                result += number;
            }
            var average = result / grades.Count;

            Console.WriteLine($"The sum is: {result}");
            Console.WriteLine($"The average is: {average:N1}");
        }
     }
}

