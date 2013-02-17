using System;

class MathExpression
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double dividend;
        double divisor;
        int mod;
        double result;

        dividend = (N * N) + (1 / (M * P)) + 1337;
        divisor = N - (128.523123123 * P);
        mod = (int)(M % 180);

        result = (dividend / divisor) + Math.Sin((double)mod);
        Console.WriteLine("{0:F6}", result);
    }
}
