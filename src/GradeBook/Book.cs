namespace GradeBook
{
	public class Book
	{
		public Book(string name)
        {
            grades = new List<double>();
			// this(object)
            Name = name; // TODO review the video on the this keyword
        }

        // Instance member/ Instance method
        public void AddGrade(double grade)
		{
			grades.Add(grade);
		}

		public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double grade in grades)//numbers
            {
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);

                //if (number > highGrade)
                //{
                //    highGrade = number;
                //}
                //if (number < lowGrade)
                //{
                //    lowGrade = number;
                //}
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }

		// A field accessible throughout the methods in the class
		// A field is declared in a class or struct. A data member of a class
		private List<double> grades;
        // The convention is that if you have a public member, the public member always has an uppercase
		public readonly string Name; // TODO investigate read only
	}
}

/* Access modifiers; public(code outside of the class can have access to it)
 * In OOP, you are protective of your state. You don't want to allow direct access to modifying stored values
 * Private: Field available only in the class 
 * The opposite of static is an instance member, be conservative when using static keyword. It negates OOP
 * Using static for a method and an instance field within it is not possible
*/