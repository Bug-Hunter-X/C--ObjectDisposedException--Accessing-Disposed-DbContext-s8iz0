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
            // Store the required data before disposing the context
            var data = context.SomeTable.FirstOrDefault();

            // ... perform operations with data
        }
    }
}