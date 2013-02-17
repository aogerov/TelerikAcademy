using System;
using System.Numerics;

class FactorialAdvanced
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        BigInteger dividend = 1;
        BigInteger divisor = 1;
        BigInteger result = 1;

        if ((1 >= N) || (N >= K))
        {
            Console.WriteLine("Error! Requested input format 1<N<K");
            return;
        }

        for (int i = 2; i <= K; i++)
        {
            if (i <= N)
            {
                dividend *= (i * i);
            }
            else
            {
                dividend *= i;
            }
        }

        for (int i = 2; i <= K - N; i++)
        {
            divisor *= i;
        }

        result = dividend / divisor;
        Console.WriteLine("Result: {0}", result);
    }
}