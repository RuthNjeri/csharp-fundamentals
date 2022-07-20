namespace GradeBook.Tests; // Namespaces allow access to other projects without inputting the "using" statement

// Test execution and discovery happens when you run the test runner
public class BookTests
{
    [Fact] 
    /*
       An attribute. Little piece of data that ia attached to the symbol that follows it. [Fact] is attached to Test1.
       The test methods are identified by the [Fact] attribute.
       Attributes are also described as decorations that we hang on sth like a method
    */
    public void Test1() // A method has to be a member of a type. Test1 is a member of Type: Class UnitTest1
    {
        /* Typically most people break a test into 3 sections
         * 1. Arrange section
         *      Put together all your test data and arrange the objects and values that you are going to use   
         */
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // 2. Act section - Invoke a method to perform a calculation or produce a result
        var result = book.GetStatistics();

        // 3. Assert section - Assert sth about the value that was computed
        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);

    }
}