//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static int number;
    static List<int> numberInBinary;
    static StringBuilder output;

    static void InputReader()
    {
        string input;

        Console.Write("Enter a number in decimal format: ");
        input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            number = int.Parse(input);
        }
    }

    static void DecToBinConverter()
    {
        numberInBinary = new List<int>();
        
        int index = 0;

        while (number > 0)
        {
            numberInBinary.Add(number % 2);
            number = number / 2;
            index++;
        }

        numberInBinary.Reverse();
    }

    static void OutputWriter()
    {
        output = new StringBuilder(numberInBinary.Capacity);
        
        foreach (var digit in numberInBinary)
        {
            output.Append(digit);
        }

        Console.WriteLine("The binary representation of the number is: {0}", output.ToString().PadLeft(32, '0'));
    }

    static void Main()
    {
        InputReader();

        DecToBinConverter();

        OutputWriter();
    }
}