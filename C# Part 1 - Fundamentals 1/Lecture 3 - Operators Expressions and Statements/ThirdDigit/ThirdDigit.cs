using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        number /= 100;
        Console.WriteLine("The third digit from right to left is 7 -> " + (number % 10 == 7));
    }
}