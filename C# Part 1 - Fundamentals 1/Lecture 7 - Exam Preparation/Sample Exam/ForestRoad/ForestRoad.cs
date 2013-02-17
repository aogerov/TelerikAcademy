using System;

class ForestRoad
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int befor;
        int after;

        for (int right = 0; right < N; right++)
        {
            befor = right;
            after = N - befor - 1;
            while (befor > 0)
            {
                Console.Write(".");
                befor--;
            }

            Console.Write("*");

            while (after > 0)
            {
                Console.Write(".");
                after--;
            }
            Console.WriteLine();
        }

        for (int left = N - 1; left > 0; left--)
        {
            befor = left - 1;
            after = N - befor - 1;
            while (befor > 0)
            {
                Console.Write(".");
                befor--;
            }

            Console.Write("*");

            while (after > 0)
            {
                Console.Write(".");
                after--;
            }
            Console.WriteLine();
        }
    }
}