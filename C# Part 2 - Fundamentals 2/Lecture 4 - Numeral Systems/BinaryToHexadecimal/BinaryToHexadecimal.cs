//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static string inputNumber;
    static List<char> results = new List<char>();

    static void InputReader()
    {
        Console.Write("Enter a number in binary format: ");

        inputNumber = Console.ReadLine();

        if (inputNumber.Length > 32)
        {
            Console.WriteLine("You've entered too big number. Please enter max 32 bit binary number.");
            InputReader();
            return;
        }
    }

    static char GetPosition(int index)
    {
        char result;
        int num = 0;

        if (index - 3 >= 0)
        {
            for (int i = index, power = 1; i >= index - 3; power *= 2 ,i--)
            {
                num = num + ((inputNumber[i] - '0') * power);
            }
        }
        else
        {
            for (int i = index, power = 1; i >= 0; power *= 2 ,i--)
            {
                num = num + ((inputNumber[i] - '0') * power);
            }
        }

        if (num < 10)
        {
            result = (char)(num + '0');
        }
        else
        {
            result = (char)(num + 'A' - 10);
        }

        return result;
    }

    static void BinToHexConverter()
    {
        for (int index = inputNumber.Length - 1; index >= 0; index -= 4)
        {
            results.Add(GetPosition(index));
        }

        results.Reverse();
    }

    static void OutputWriter()
    {
        Console.Write("The hexadecimal representation of the number is: ");

        foreach (var res in results)
        {
            Console.Write(res);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        InputReader();

        BinToHexConverter();

        OutputWriter();
    }
}