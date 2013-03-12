using System;

class TestProgram
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Sum: {0}", numbers.Sum());
        Console.WriteLine("Product: {0}", numbers.Product());
        Console.WriteLine("Min: {0}", numbers.Min());
        Console.WriteLine("Max: {0}", numbers.Max());
        Console.WriteLine("Average: {0}", numbers.Average());
    }
}