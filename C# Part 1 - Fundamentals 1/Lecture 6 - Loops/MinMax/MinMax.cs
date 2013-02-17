using System;

class MinMax
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int count = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        int minNumber = number;
        int maxNumber = number;

        for (int i = 1; i < count; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (maxNumber < number)
            {
                maxNumber = number;
            }
            if (minNumber > number)
            {
                minNumber = number;
            }
        }

        Console.WriteLine("Min: {0}\r\nMax: {1}", minNumber, maxNumber);
    }
}