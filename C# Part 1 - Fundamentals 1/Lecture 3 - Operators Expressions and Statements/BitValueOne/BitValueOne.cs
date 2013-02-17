using System;

class BitValueOne
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1;
        mask <<= p;
        mask &= v;
        mask >>= p;
        bool isOne = (mask == 1);

        Console.WriteLine("v={0};p={1} -> {2}",  v, p, isOne);
    }
}