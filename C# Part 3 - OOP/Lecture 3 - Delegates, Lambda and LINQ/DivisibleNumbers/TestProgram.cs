using System;

class TestProgram
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        Console.WriteLine("Divisible numbers by 7 and 3 with conditional statement:");

        foreach (var number in DivisibleNumbers.FindWithConditional(numbers))
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\r\nDivisible numbers by 7 and 3 with lambda expressions:");

        foreach (var number in DivisibleNumbers.FindWithLambda(numbers))
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\r\nDivisible numbers by 7 and 3 with LINQ:");

        foreach (var number in DivisibleNumbers.FindWithLinq(numbers))
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
    }
}