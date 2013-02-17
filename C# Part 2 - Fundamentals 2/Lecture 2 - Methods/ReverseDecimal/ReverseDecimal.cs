//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;
using System.Text;

class ReverseDecimal
{
    static decimal realNumber;
    static decimal reversedRealNumber;

    static void InputReader()
    {
        Console.Write("Enter decimal number: ");

        string input = Console.ReadLine();

        if (decimal.TryParse(input, out realNumber))
        {
            realNumber = decimal.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input!");
            InputReader();
            return;
        }
    }

    static void ReverseDigits()
    {
        string realNumberForReverse = Convert.ToString(realNumber);
        
        char[] splitters = new char[] { ',', '.' };
        
        string[] parts = realNumberForReverse.Split(splitters);

        StringBuilder sb = new StringBuilder(realNumberForReverse.Length);

        for (int part = parts.Length - 1; part >= 0; part--)
        {
            for (int index = parts[part].Length - 1; index >= 0; index--)
            {
                sb.Append(parts[part][index]);
            }
        }

        if (parts.Length > 1)
        {
            int pointIndex = parts[0].Length;

            char point = realNumberForReverse[pointIndex];

            sb.Insert(pointIndex, point);
        }

        reversedRealNumber = decimal.Parse(sb.ToString());
    }

    static void PrintReversedNumber()
    {
        Console.WriteLine("\r\n{0} - input number", realNumber);
        Console.WriteLine("{0} - output number\r\n", reversedRealNumber);
    }

    static void Main()
    {
        InputReader();

        ReverseDigits();

        PrintReversedNumber();
    }
}