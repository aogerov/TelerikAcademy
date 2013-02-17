using System;

class PositiveOrNegativeResult
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());
        bool isPositive = true;

        if (first < 0)
        {
            isPositive = !isPositive;
        }
        if (second < 0)
        {
            isPositive = !isPositive;
        }
        if (third < 0)
        {
            isPositive = !isPositive;
        }

        Console.Write("The product of three has ");
        Console.WriteLine(isPositive ? "positive sign." : "negative sign.");
    }
}