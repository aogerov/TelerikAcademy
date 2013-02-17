using System;
using System.Numerics;

class CatalanNumber
{
    static BigInteger Factorial(int factorial)
    {
        BigInteger result = 1;
        for (int i = 1; i <= factorial; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        string input = Console.ReadLine();
        int N;
        if ((int.TryParse(input, out N)) && (N >= 0))
        {
            N = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }

        BigInteger dividend = Factorial(N * 2);
        BigInteger divisorOne = Factorial(N + 1);
        BigInteger divisorTwo = Factorial(N);

        BigInteger result = dividend / (divisorOne * divisorTwo);
        Console.WriteLine("Result: {0}", result);
    }
}