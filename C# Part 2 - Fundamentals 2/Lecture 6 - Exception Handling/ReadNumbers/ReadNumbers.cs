//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadNumbers
{
    static int[] numbers = new int[10];
    static bool inputError;

    static void ReadNumber(int index)
    {
        Console.Write("number {0}: ", index + 1);
        string input = Console.ReadLine();

        try
        {
            numbers[index] = int.Parse(input);

            if ((numbers[index] < 1) || (numbers[index] > 100))
            {
                throw new ArgumentException();
            }

            if (index > 0)
            {
                if (numbers[index] <= numbers[index - 1])
                {
                    throw new ArgumentException();
                }
            }
        }
        catch (FormatException)
        {
            inputError = true;
            Console.WriteLine("Error! Non-number text is entered!");
        }
        catch (ArgumentException)
        {
            inputError = true;
            Console.WriteLine("Error! You've entered an invalid number!");
        }
    }

    static void PrintResult()
    {
        Console.WriteLine("Correct numbers format!");
        Console.WriteLine(String.Join(", ", numbers));
    }

    static void Main()
    {
        Console.WriteLine("Enter 10 numbers in the range 1 < a1 < … < a10 < 100");

        for (int index = 0; index < 10; index++)
        {
            if (inputError)
            {
                return;
            }

            ReadNumber(index);
        }

        PrintResult();
    }
}