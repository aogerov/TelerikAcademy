using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger t1 = int.Parse(Console.ReadLine());
        BigInteger t2 = int.Parse(Console.ReadLine());
        BigInteger t3 = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger result = new BigInteger();

        if (n > 3)
        {
            while ((n - 3) > 0)
            {
                result = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = result;
                n--;
            }
            Console.WriteLine(result);
        }
        else
        {
            if (n == 1)
            {
                Console.WriteLine(t1);
            }
            if (n == 2)
            {
                Console.WriteLine(t2);
            }
            if (n == 3)
            {
                Console.WriteLine(t3);
            }
        }
    }
}