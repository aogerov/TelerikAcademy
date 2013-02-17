using System;

class FactorialExpert
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int X = int.Parse(Console.ReadLine());

        decimal dividend = 1;
        decimal divisor = 1;
        decimal sum = 1;

        for (int i = 1; i <= N; i++)
        {
            dividend *= i;
            divisor *= X;
            sum += (dividend / divisor);
        }

        Console.WriteLine("Result: {0}", sum);
    }
}
