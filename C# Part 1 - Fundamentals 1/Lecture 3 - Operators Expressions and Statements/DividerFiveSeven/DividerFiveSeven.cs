using System;

class DividerFiveSeven
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number % 5 == 0) && (number % 7 == 0))
        {
        Console.WriteLine("The number {0} can be divided by 5 and 7 without remainder.", number);
        }
        else
        {
            Console.WriteLine("The number {0} CAN'T be divided by 5 and 7 without remainder.", number);
        }
    }
}