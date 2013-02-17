//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class CheckLeapYear
{
    static int year;

    static void InputReader()
    {
        Console.Write("Enter some year: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out year))
        {
            year = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong year input!");
            InputReader();
            return;
        }
    }

    static void PrintOutput()
    {
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} year is leep.", year);
        }
        else
        {
            Console.WriteLine("{0} year is NOT leep.", year);
        }
    }

    static void Main()
    {
        InputReader();

        PrintOutput();
    }
}