using System;

class HelloWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        Object helloWorld = hello + " " + world;
        string helloWorldString = (string)helloWorld;
        Console.WriteLine(helloWorldString);
    }
}
