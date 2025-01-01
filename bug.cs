public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some operations with context
        }

        // Attempting to access context here will result in an exception because context has been disposed
        var data = context.SomeTable.FirstOrDefault();
    }
}