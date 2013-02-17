/*Write a program that can solve these tasks:
* Reverses the digits of a number
* Calculates the average of a sequence of integers
* Solves a linear equation a * x + b = 0
* 		Create appropriate methods.
* 		Provide a simple text-based menu for the user to choose which task to solve.
* 		Validate the input data:
* The decimal number should be non-negative
* The sequence should not be empty
* a should not be equal to 0
*/

using System;

class SolveTasks
{
    static int choice;

    static void PrintChoices()
    {
        Console.WriteLine("1 - Reverses the digits of a number");
        Console.WriteLine("2 - Calculates the average of a sequence of integers");
        Console.WriteLine("3 - Solves a linear equation a * x + b = 0");
        Console.Write("\r\nMake a choice: ");

        choice = int.Parse(Console.ReadLine());

        if ((choice < 1) || (choice > 3))
        {
            Console.WriteLine("Wrong choice! Try again!");
            PrintChoices();
            return;
        }

        Console.WriteLine();
    }

    static void ReverseDigits()
    {
        Console.Write("Enter some non-negative number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Wrong input! Try again!");
            ReverseDigits();
            return;
        }

        string num = number.ToString();
        string output = "";

        for (int i = 0; i < num.Length; i++)
        {
            output = num[i] + output;
        }

        Console.WriteLine("\r\nReversed number: {0}\r\n", output);
    }

    static void SequenceAverage()
    {
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        string input = Console.ReadLine();
        string[] nums = input.Split(' ');

        long sum = 0;
        int[] numbers = new int[nums.Length];

        try
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(nums[index]);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Wrong input! Enter only numbers with one space between.");
            SequenceAverage();
            return;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }

        Console.Write("The average of the sequence is: {0}\r\n\r\n", sum / (decimal)numbers.Length);
    }

    static void LinearEquation()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Wrong input! Coefficient a has to be different than 0.");
            LinearEquation();
            return;
        }

        Console.WriteLine("Result x = {0}\r\n", -b / a);
    }

    static void Main()
    {
        PrintChoices();

        if (choice == 1)
        {
            ReverseDigits();
        }
        else if (choice == 2)
        {
            SequenceAverage();
        }
        else if (choice == 3)
        {
            LinearEquation();
        }
    }
}