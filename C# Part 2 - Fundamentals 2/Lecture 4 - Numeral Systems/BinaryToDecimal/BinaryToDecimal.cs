//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static string inputNumber;
    static int numberInDecimal;

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

    static void BinToDecConverter()
    {
        int digit;
        int power = 1;

        if (inputNumber[inputNumber.Length - 1] == '0')
        {
            numberInDecimal = 0;
        }
        else
        {
            numberInDecimal = 1;
        }

        for (int index = 0; index < inputNumber.Length - 1; index++)
        {
            digit = int.Parse(inputNumber[inputNumber.Length - index - 2].ToString());
            power = power * 2;
            numberInDecimal = numberInDecimal + (digit * power);
        }
    }

    static void PrintNumber()
    {
        Console.WriteLine("The decimal representation of the number is: {0}", numberInDecimal);
    }

    static void Main()
    {
        InputReader();

        BinToDecConverter();

        PrintNumber();
    }
}