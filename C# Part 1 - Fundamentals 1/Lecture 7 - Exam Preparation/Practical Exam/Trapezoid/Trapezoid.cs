using System;

class Trapezoid
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < N; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int row = 1; row < N; row++)
        {
            int firstPointsCount = N - row;
            int secondPointsCount = ((N * 2) - 2) - firstPointsCount;
            while (firstPointsCount > 0)
            {
                Console.Write(".");
                firstPointsCount--;
            }

            Console.Write("*");

            while (secondPointsCount > 0)
            {
                Console.Write(".");
                secondPointsCount--;
            }

            Console.WriteLine("*");
        }

        for (int i = 0; i < N * 2; i++)
        {
            Console.Write("*");
        }
    }
}