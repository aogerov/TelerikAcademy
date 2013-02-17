//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static string inputNumber;
    static int numberInDecimal;

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

    static void HexToDecConverter()
    {
        int digit;
        char digitAsChar;
        int power = 1;

        if (inputNumber[inputNumber.Length - 1] == '0')
        {
            numberInDecimal = 0;
        }
        else
        {
            digitAsChar = inputNumber[inputNumber.Length - 1];

            if ((digitAsChar >= '0') && (digitAsChar <= '9'))
            {
                digit = int.Parse(digitAsChar.ToString());
                numberInDecimal = digit;
            }
            else
            {
                digit = int.Parse((digitAsChar - 55).ToString());
                numberInDecimal = digit;
            }
        }

        for (int index = 0; index < inputNumber.Length - 1; index++)
        {
            digitAsChar = inputNumber[inputNumber.Length - index - 2];

            if ((digitAsChar >= '0') && (digitAsChar <= '9'))
            {
                digit = int.Parse(digitAsChar.ToString());
            }
            else
            {
                digit = int.Parse((digitAsChar - 55).ToString());
            }

            power = power * 16;
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

        HexToDecConverter();

        PrintNumber();
    }
}