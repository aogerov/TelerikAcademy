//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.

using System;

class PrintName
{
    static void PrintAName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if (name.Length > 0)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        else
        {
            Console.WriteLine("Wrong input!");
            PrintAName();
        }
    }

    static void Main()
    {
        PrintAName();
    }
}