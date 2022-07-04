namespace GradeBook
{
	 class Book
	{
		public Book(string name)
        {
            grades = new List<double>();
			// this(object)
            this.name = name;
        }

        // Instance member/ Instance method
        public void AddGrade(double grade)
		{
			grades.Add(grade);
		}

		// A field accessible throughout the methods in the class
		// A field is declared in a class or struct. A data member of a class
		List<double> grades;
		private string name;
	}
}

/* Access modifiers; public(code outside of the class can have access to it)
 * In OOP, you are protective of your state. You don't want to allow direct access to modifying stored values
 * Private: Field available only in the class 
*/