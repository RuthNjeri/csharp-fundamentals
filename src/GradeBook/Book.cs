namespace GradeBook
{
	 class Book
	{
		public Book(string name)
        {
            grades = new List<double>();
			// this(object)
            this.name = name; // TODO review the video on the this keyword
        }

        // Instance member/ Instance method
        public void AddGrade(double grade)
		{
			grades.Add(grade);
		}

		public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)//numbers
            {
                highGrade = Math.Max(highGrade, number);
                lowGrade = Math.Min(lowGrade, number);

                //if (number > highGrade)
                //{
                //    highGrade = number;
                //}
                //if (number < lowGrade)
                //{
                //    lowGrade = number;
                //}
                result += number;
            }
            var average = result / grades.Count;

            Console.WriteLine($"The sum is: {result}");
            Console.WriteLine($"The average is: {average:N1}");
            Console.WriteLine($"The highest grade is: {highGrade:N1}");
            Console.WriteLine($"The lowest grade is: {lowGrade:N1}");
        }

		// A field accessible throughout the methods in the class
		// A field is declared in a class or struct. A data member of a class
		private List<double> grades;
		private readonly string name; // TODO investigate read only
	}
}

/* Access modifiers; public(code outside of the class can have access to it)
 * In OOP, you are protective of your state. You don't want to allow direct access to modifying stored values
 * Private: Field available only in the class 
 * The opposite of static is an instance member, be conservative when using static keyword. It negates OOP
 * Using static for a method and an instance field within it is not possible
*/