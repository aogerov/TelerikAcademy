using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourth = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifth = int.Parse(Console.ReadLine());

        int biggestNumber = first;

        if (second > biggestNumber)
        {
            biggestNumber = second;
        }
        if (third > biggestNumber)
        {
            biggestNumber = third;
        }
        if (fourth > biggestNumber)
        {
            biggestNumber = fourth;
        }
        if (fifth > biggestNumber)
        {
            biggestNumber = fifth;
        }

        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}