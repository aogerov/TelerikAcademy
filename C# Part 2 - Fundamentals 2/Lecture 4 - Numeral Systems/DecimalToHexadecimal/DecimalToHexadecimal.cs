//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Text;

class DecimalToHexadecimal
{
    static int number;
    static List<int> numberInHex;
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

    static void DecToHexConverter()
    {
        numberInHex = new List<int>();

        int index = 0;

        while (number > 0)
        {
            numberInHex.Add(number % 16);
            number = number / 16;
            index++;
        }

        numberInHex.Reverse();
    }

    static void OutputWriter()
    {
        output = new StringBuilder(numberInHex.Capacity);

        foreach (var digit in numberInHex)
        {
            if (digit > 9)
            {
                output.Append((char)(digit + 55));
            }
            else
            {
                output.Append(digit);
            }
        }

        Console.WriteLine("The hexadecimal representation of the number is: {0}", output);
    }

    static void Main()
    {
        InputReader();

        DecToHexConverter();

        OutputWriter();
    }
}