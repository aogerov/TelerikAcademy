using System;
using System.Numerics;

class FactorialBasic
{
    static void Main()
    {
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        BigInteger divisionResult = 1;

        if ((1 >= K) || (K >= N))
        {
            Console.WriteLine("Error! Requested input format 1<K<N");
            return;
        }

        for (int i = K + 1; i <= N; i++)
        {
            divisionResult *= i;
        }

        Console.WriteLine("Result: {0}", divisionResult);
    }
}