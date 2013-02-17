using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        if (second > third)
        {
            if (second > first)
            {
                first = second;
            }
        }
        else
        {
            if (third > first)
            {
                first = third;
            }
        }

        Console.WriteLine("{0} is the biggest number", first);
    }
}