using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        BigInteger firstNumber = new BigInteger(0);
        BigInteger secondNumber = new BigInteger(1);
        BigInteger temp = new BigInteger(0);
        
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("{0,-3} -> {1}", (i + 1), firstNumber);
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp + firstNumber;
        }
    }
}