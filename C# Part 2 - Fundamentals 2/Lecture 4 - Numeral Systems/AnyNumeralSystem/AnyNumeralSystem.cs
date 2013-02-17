//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class AnyNumeralSystem
{
    static string inputNumber;
    static int startBase;
    static int endBase;

    static int numberInDec;
    static string outputNumber;

    static void InputReader()
    {
        Console.Write("Enter some number: ");
        inputNumber = Console.ReadLine();

        Console.Write("Enter number's base: ");
        startBase = int.Parse(Console.ReadLine());

        Console.Write("Enter the base for convert: ");
        endBase = int.Parse(Console.ReadLine());

        //inputNumber = "87A3B18";
        //startBase = 12;
        //endBase = 14;
    }

    static void SwitchToDec()
    {
        int power = 1;
        int iterationNumber;

        for (int index = inputNumber.Length - 1; index >= 0; index--)
        {
            if (inputNumber[index] <= '9')
            {
                iterationNumber = inputNumber[index] - '0';
            }
            else
            {
                iterationNumber = inputNumber[index] - 'A' + 10;
            }

            numberInDec = numberInDec + (iterationNumber * power);

            power = power * startBase;
        }
    }

    static void SwitchToSecondBase()
    {
        int iterationChar;
        char iterationNumber = new char();

        while (numberInDec > 0)
        {
            iterationChar = numberInDec % endBase;

            if (iterationChar <= 9)
            {
                iterationNumber = (char)(iterationChar + '0');
            }
            else
            {
                iterationNumber = (char)(iterationChar + 'A' - 10);
            }

            outputNumber = iterationNumber + outputNumber;

            numberInDec = numberInDec / endBase;
        }
    }

    static void PrintNumber()
    {
        Console.WriteLine("The representation of the number in base {0} is: {1}", endBase, outputNumber);
    }

    static void Main()
    {
        InputReader();

        SwitchToDec();

        SwitchToSecondBase();

        PrintNumber();
    }
}