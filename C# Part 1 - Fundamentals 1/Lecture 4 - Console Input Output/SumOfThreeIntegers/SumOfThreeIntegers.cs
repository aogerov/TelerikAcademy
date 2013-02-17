using System;

class SumOfThreeIntegers
{
    static void Main()
    {
        string input;
        int first;
        int second;
        int third;

        Console.Write("Enter first integer: ");
        input = Console.ReadLine();
        first = int.Parse(input);
        Console.Write("Enter second integer: ");
        input = Console.ReadLine();
        second = int.Parse(input);
        Console.Write("Enter third integer: ");
        input = Console.ReadLine();
        third = int.Parse(input);

        Console.WriteLine("The sum of {0}, {1} and {2} is equal to: {3}", first, second, third, (first + second + third));
    }
}