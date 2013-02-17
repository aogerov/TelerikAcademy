using System;

class NumberValuePosition
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value: ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1;
        if (v == 1)
        {
            mask <<= p;
            n |= mask;
        }
        else
        {
            mask <<= p;
            mask = ~mask;
            n &= mask;
        }

        Console.WriteLine("Modified number: " + n);
    }
}