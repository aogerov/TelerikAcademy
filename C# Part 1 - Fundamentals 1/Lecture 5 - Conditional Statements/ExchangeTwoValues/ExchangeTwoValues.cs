using System;

class ExchangeTwoValues
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        if (second > first)
        {
            second = second + first;
            first = second - first;
            second = second - first;
        }

        Console.WriteLine("First number: {0}\r\nSecond number: {1}", first, second);
    }
}