
using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number between 1 and 20: ");
        string input = Console.ReadLine();
        int N;
        while (!(int.TryParse(input, out N)) || (N < 1) || (N > 20))
        {
            Console.WriteLine("Wrong input! Enter number between 1 and 20");
            input = Console.ReadLine();
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = row + 1; col <= row + N; col++)
            {
                if (col < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(" " + col);
            }
            Console.WriteLine();
        }
    }
}
