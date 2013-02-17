//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class HexadecimalToBinary
{
    static string inputNumber;
    static List<int> numberInBinary;
    static StringBuilder output = new StringBuilder();

    static void InputReader()
    {
        Console.Write("Enter a number in hexadecimal format: ");

        inputNumber = Console.ReadLine();
        inputNumber = inputNumber.ToUpper();

        foreach (var digit in inputNumber)
        {
            if ((digit < '0') || (digit > '9'))
            {
                if ((digit < 'A') || (digit > 'F'))
                {
                    Console.WriteLine("Incorrect number format!");
                    inputNumber = "";
                    InputReader();
                    return;
                }
            }
        }
    }

    static int GetCurrent(char checkChar)
    {
        int output;

        if (checkChar <= '9')
        {
            output = checkChar - '0';
        }
        else
        {
            output = checkChar - 'A' + 10;
        }

        return output;
    }

    static void HexToBinConverter()
    {
        numberInBinary = new List<int>();

        for (int index = inputNumber.Length - 1; index >= 0; index--)
        {
            int num = GetCurrent(inputNumber[index]);

            for (int i = 0; i < 4; num /= 2, i++)
            {
                numberInBinary.Add(num % 2);
            }
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

        HexToBinConverter();

        OutputWriter();
    }
}
