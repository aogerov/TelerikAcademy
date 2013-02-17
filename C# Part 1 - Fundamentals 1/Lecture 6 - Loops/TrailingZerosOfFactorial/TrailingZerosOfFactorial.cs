
using System;
using System.Numerics;

class TrailingZerosOfFactorial
{
    static void Main()
    {
        Console.Write("Enter factorial: ");
        int factorial = int.Parse(Console.ReadLine());
        int divisor = 5;
        int count = 0;
        while (divisor <= factorial)
        {
            count += factorial / divisor;
            divisor *= 5;
        }
        Console.WriteLine("The trailing zeros of the factorial are: {0}", count);
    }
}