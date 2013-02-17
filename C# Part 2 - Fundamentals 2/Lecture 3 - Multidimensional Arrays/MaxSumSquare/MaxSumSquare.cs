//Write a program that reads a rectangular matrix of size N x M
//and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSumSquare
{
    static void Main()
    {
        //N & M input reader
        Console.Write("Enter the rows count of the matrix, N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter the columns count of the matrix, M: ");
        int M = int.Parse(Console.ReadLine());
        
        //test values
        //int N = 6;
        //int M = 4;
        //int[,] matrix = { { 1, 4, 3, 7 }, { 4, 7, 2, 9 }, { 9, 1, 4, 7 }, { 5, 2, 7, 1 }, {2, 7, 1, 3}, {1, 7, 2, 8} };

        //check if N or M are lower than 3
        if ((N < 3) || (M < 3))
        {
            Console.WriteLine("\r\nWrong input! N & M has to be at least 3.");
            return;
        }

        //matrix initialization
        Console.WriteLine("Enter the numbers of the matrix:");
        int[,] matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("Index ({0},{1}): ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //generating array with sums
        int[,] sums = new int[N - 2, M - 2];

        //calculating sums
        for (int row = 0; row < N - 2; row++)
        {
            for (int col = 0; col < M - 2; col++)
            {
                for (int matrixRow = row; matrixRow < row + 3; matrixRow++)
                {
                    for (int matrixCol = col; matrixCol < col + 3; matrixCol++)
                    {
                        sums[row, col] += matrix[matrixRow, matrixCol];
                    }
                }
            }
        }

        //locate max sum position
        int rowPosition = -1;
        int colPosition = -1;
        int maxSum = int.MinValue;
        for (int row = 0; row < sums.GetLength(0); row++)
        {
            for (int col = 0; col < sums.GetLength(1); col++)
            {
                if (maxSum < sums[row,col])
                {
                    maxSum = sums[row, col];
                    rowPosition = row;
                    colPosition = col;
                }
            }
        }

        //print full matrix
        Console.WriteLine("\r\nFull matrix:");
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write(matrix[row, col]);

                if (col < M - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        //print the area with the max sum
        Console.WriteLine("\r\nArea with the max sum:");
        for (int row = rowPosition; row < rowPosition + 3; row++)
        {
            for (int col = colPosition; col < colPosition + 3; col++)
            {
                Console.Write(matrix[row,col]);
                
                if (col < colPosition + 2)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Result: {0}", maxSum);
    }
}