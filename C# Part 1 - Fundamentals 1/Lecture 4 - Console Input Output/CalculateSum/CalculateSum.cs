using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int count = int.Parse(input);

        int number;
        int sum = 0;

        Console.WriteLine("Enter {0} numbers to get their sum: ", count);
        for (int i = 0; i < count; i++)
        {
            input = Console.ReadLine();
            number = int.Parse(input);
            sum += number;
        }

        Console.WriteLine("Sum: " + sum);
    }
}