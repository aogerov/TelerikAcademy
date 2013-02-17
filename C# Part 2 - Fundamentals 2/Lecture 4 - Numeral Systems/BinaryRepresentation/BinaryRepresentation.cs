//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryRepresentation
{
    static void Main()
    {
        string binaryRepresentation = "";

        Console.Write("Enter some 16-bit signed integer number: ");
        short number = short.Parse(Console.ReadLine());

        int mask;

        for (int index = 0; index < 16; index++)
        {
            mask = number >> index;
            mask = mask & 1;

            binaryRepresentation = mask + binaryRepresentation;
        }

        Console.WriteLine("The binary representation of the number is: {0}", binaryRepresentation);
    }
}