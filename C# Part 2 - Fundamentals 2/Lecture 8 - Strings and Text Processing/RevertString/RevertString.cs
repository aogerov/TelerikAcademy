//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class RevertString
{
    static void Main()
    {
        Console.Write("Enter some string: ");
        string input = Console.ReadLine();
        //string input = "Telerik";

        StringBuilder reversed = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        Console.WriteLine("\r\nReversed string: {0}\r\n", reversed);
    }
}