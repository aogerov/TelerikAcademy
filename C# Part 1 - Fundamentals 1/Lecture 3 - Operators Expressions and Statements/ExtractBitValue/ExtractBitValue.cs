using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1;
        mask <<= b;
        mask &= i;
        mask >>= b;

        Console.WriteLine("i={0};b={1} -> {2}", i, b, mask);
    }
}