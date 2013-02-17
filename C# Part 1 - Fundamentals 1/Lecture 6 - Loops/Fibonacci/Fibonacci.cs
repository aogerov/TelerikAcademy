using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter a number N for the first N members of the sequence of Fibonacci: ");
        int count = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 1;
        BigInteger secondNumber = 1;
        BigInteger result = 1;

        if (count == 0)
        {
            Console.WriteLine("Result: 0");
            return;
        }

        for (int i = 2; i < count; i++)
        {
            result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = result;
        }

        Console.WriteLine("Result: {0}", result);
    }
}