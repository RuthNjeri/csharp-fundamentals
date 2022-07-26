namespace GradeBook.Tests; // Namespaces allow access to other projects without inputting the "using" statement

// Test execution and discovery happens when you run the test runner
public class TypeTests
{
    [Fact] 
    /*
       An attribute. Little piece of data that ia attached to the symbol that follows it. [Fact] is attached to Test1.
       The test methods are identified by the [Fact] attribute.
       Attributes are also described as decorations that we hang on sth like a method
    */
    public void GetBookReturnsDifferentObjects() 
    {
        /* Typically most people break a test into 3 sections
         * 1. Arrange section
         *      Put together all your test data and arrange the objects and values that you are going to use   
         */
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");


        // 2. Act section - Invoke a method to perform a calculation or produce a result

        // 3. Assert section - Assert sth about the value that was computed
        // Testing different pieces of state in these two objects.
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        // Variables hold values which can be references or pointers to an object in memory
        // Variables hold values not objects, so the value is the location in memory for the object.
        var book1 = GetBook("Book 1");
        var book2 = book1;

        // Check what value goes into book 2...could it be
        // i) A reference that points to a different book?
        // ii) Is it a copy of the existing book object, book1
        // iii) Or do we take a pointer or reference that is in book1 and copy it to book2
        // One way to check
        /*
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 1", book2.Name);
        */
        // Another way
        Assert.Same(book1,book2);
        // Assert.Same behind the scenes does...
        // ReferenceEquals is a static method available in class Object
        // Everything in dotnet derives from the Object base class.
        Assert.True(Object.ReferenceEquals(book1, book2));
    }

    // By default a member is private
    // The keyword object is the lowest base type in .net framework
    Book GetBook(string name)
    {
        return new Book(name);
    }
}