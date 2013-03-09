using System;

[Version(234.8964)]
struct TestStruct
{
    public int Number { get; set; }
}

[Version(41.23)]
class TestClass
{
    static void Main()
    {
        object[] classAttributes = typeof(TestClass).GetCustomAttributes(false);

        foreach (Version attribute in classAttributes)
        {
            Console.WriteLine("Test class version - {0}.{1}", attribute.Major, attribute.Minor);
        }
        Console.WriteLine("------------------------------");

        object[] interfaceAttributes = typeof(TestStruct).GetCustomAttributes(false);

        foreach (Version attribute in interfaceAttributes)
        {
            Console.WriteLine("Test struct version - {0}.{1}", attribute.Major, attribute.Minor);
        }
        Console.WriteLine("------------------------------");
    }
}