using System;

class SortThreeRealValues
{
    private static int first;
    private static int second;
    private static int third;

    private static void ExchangeSecondFirst()
    {
        second = second + first;
        first = second - first;
        second = second - first;
    }

    private static void ExchangeThirdSecond()
    {
        third = third + second;
        second = third - second;
        third = third - second;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        third = int.Parse(Console.ReadLine());

        if (second > first)
        {
            ExchangeSecondFirst();

            if (third > second)
            {
                ExchangeThirdSecond();
            }
            if (second > first)
            {
                ExchangeSecondFirst();
            }
        }
        else
        {
            if (third > second)
            {
                ExchangeThirdSecond();
            }
            if (second > first)
            {
                ExchangeSecondFirst();
            }
        }

        Console.WriteLine("The numbers in descedenting order: {0} {1} {2}", first, second, third);
    }
}