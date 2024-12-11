public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize MyProperty
    public ExampleClass()
    {
        MyProperty = 0; // or any other default value
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; 
    }
} 