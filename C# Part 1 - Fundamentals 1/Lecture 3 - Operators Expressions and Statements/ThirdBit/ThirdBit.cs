using System;

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int mask = 1;
        mask <<= 3;
        mask &= number;
        mask >>= 3;

        Console.WriteLine("The third bit of the number {0} is -> {1}", number, mask);
    }
}