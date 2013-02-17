using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine((number % 2 == 0) ? "The number is even" : "The number is odd");
    }
}