
using System;

class SpiralMatrix
{
    static int N;
    static int[,] matrix;
    static int rowPosition = 0;
    static int colPosition = 0;
    static bool rightDirection = true;
    static bool downDirection = false;
    static bool leftDirection = false;
    static bool upDirection = false;

    static void RightDirection(int number)
    {
        if ((colPosition < N) && (matrix[rowPosition, colPosition] == 0))
        {
            matrix[rowPosition, colPosition] = number;
            if ((colPosition < N - 1) && (matrix[rowPosition, colPosition + 1] == 0))
            {
                colPosition++;
            }
            else
            {
                rowPosition++;
                rightDirection = false;
                downDirection = true;
                return;
            }
        }
    }

    static void DownDirection(int number)
    {
        if ((rowPosition < N) && (matrix[rowPosition, colPosition] == 0))
        {
            matrix[rowPosition, colPosition] = number;
            if ((rowPosition < N - 1) && (matrix[rowPosition + 1, colPosition] == 0))
            {
                rowPosition++;
            }
            else
            {
                colPosition--;
                downDirection = false;
                leftDirection = true;
                return;
            }
        }
    }

    static void LeftDirection(int number)
    {
        if ((colPosition >= 0) && (matrix[rowPosition, colPosition] == 0))
        {
            matrix[rowPosition, colPosition] = number;
            if ((colPosition >= 1) && (matrix[rowPosition, colPosition - 1] == 0))
            {
                colPosition--;
            }
            else
            {
                rowPosition--;
                leftDirection = false;
                upDirection = true;
                return;
            }
        }
    }

    static void UpDirection(int number)
    {
        if ((rowPosition >= 0) && (matrix[rowPosition, colPosition] == 0))
        {
            matrix[rowPosition, colPosition] = number;
            if ((rowPosition >= 1) && (matrix[rowPosition - 1, colPosition] == 0))
            {
                rowPosition--;
            }
            else
            {
                colPosition++;
                upDirection = false;
                rightDirection = true;
                return;
            }
        }
    }

    private static void PrintMatrix()
    {
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write("  ");
                }
                if ((matrix[row, col] > 9) && (matrix[row, col] < 100))
                {
                    Console.Write(" ");
                }
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        N = int.Parse(Console.ReadLine());
        matrix = new int[N, N];

        for (int number = 1; number <= N * N; number++)
        {
            if (rightDirection)
            {
                RightDirection(number);
                continue;
            }

            if (downDirection)
            {
                DownDirection(number);
                continue;
            }

            if (leftDirection)
            {
                LeftDirection(number);
                continue;
            }

            if (upDirection)
            {
                UpDirection(number);
                continue;
            }
        }

        PrintMatrix();
    }
}