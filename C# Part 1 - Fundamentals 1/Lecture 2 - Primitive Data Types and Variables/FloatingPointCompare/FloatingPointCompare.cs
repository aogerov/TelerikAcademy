using System;

class FloatingPointCompare
{
    static void Main()
    {
        double first = 5.3;
        double second = 6.01;
        double third = 5.00000001;
        double fourth = 5.00000003;

        Console.WriteLine("5.3 is equal to 6.01 -> {0}", (Math.Round(first, 6) == Math.Round(second, 6)));
        Console.WriteLine("5.00000001 is equal to 5.00000003 -> {0}", (Math.Round(third, 6) == Math.Round(fourth, 6)));
    }
}