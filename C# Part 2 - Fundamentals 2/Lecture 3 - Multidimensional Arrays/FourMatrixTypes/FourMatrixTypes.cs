//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//The exaples can be seen on the PowerPoint presentation.

using System;
using System.Text;

class FourMatrixTypes
{
    static int number;

    static void PrintMatrix(int[,] array)
    {
        StringBuilder sb = new StringBuilder();

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row, col] < 10)
                {
                    sb.Append("   ");
                }
                else if (array[row, col] < 100)
                {
                    sb.Append("  ");
                }
                else if (array[row, col] < 1000)
                {
                    sb.Append(" ");
                }

                sb.Append(array[row, col]);
            }
            sb.Append("\r\n");
        }

        Console.WriteLine(sb);
    }

    static void Main()
    {
        //read matrix size
        Console.Write("Enter the size of the matrix, N: ");
        string input = Console.ReadLine();
        int N;
        if (int.TryParse(input, out N))
        {
            N = int.Parse(input);
        }

        //matrix initialization
        int[,] typeA = new int[N, N];
        int[,] typeB = new int[N, N];
        int[,] typeC = new int[N, N];
        int[,] typeD = new int[N, N];

        //set numbers to type A
        number = 1;

        for (int col = 0; col < N; col++)
        {
            for (int row = 0; row < N; row++)
            {
                typeA[row, col] = number;
                number++;
            }
        }

        //set numbers to type B
        number = 1;

        for (int col = 0; col < N; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < N; row++)
                {
                    typeB[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = 0; row < N; row++)
                {
                    typeB[N - row - 1, col] = number;
                    number++;
                }
            }
        }

        //set numbers to type C
        number = 0;
        int rowC = N - 1;
        int colC = 0;

        while (number < N * N)
        {
            int row = rowC;
            int col = colC;

            while ((row >= 0) && (row < N) && (col >= 0) && (col < N) && (number < N * N))
            {
                number++;
                typeC[row, col] = number;
                row++;
                col++;
            }

            if (rowC > 0)
            {
                rowC--;
            }
            else
            {
                colC++;
            }
        }

        //set numbers to type D
        number = 1;
        int rowD = 0;
        int colD = 0;
        bool downDirection = true;
        bool rightDirection = false;
        bool upDirection = false;
        bool leftDirection = false;

        while (number <= N * N)
        {
            if (downDirection)
            {
                while ((typeD[rowD, colD] == 0) && (number <= N * N))
                {
                    typeD[rowD, colD] = number;
                    number++;

                    if ((rowD < N - 1) && (typeD[rowD + 1, colD] == 0))
                    {
                        rowD++;
                    }
                    else
                    {
                        break;
                    }
                }
                
                downDirection = false;
                rightDirection = true;
                if (colD < N - 1)
                {
                    if (typeD[rowD, colD + 1] == 0)
                    {
                        colD++;
                    }
                }
            }

            if (rightDirection)
            {
                while ((typeD[rowD,colD] == 0) && (number <= N * N))
                {
                    typeD[rowD, colD] = number;
                    number++;

                    if ((colD < N - 1) && (typeD[rowD, colD + 1] == 0))
                    {
                        colD++;
                    }
                    else
                    {
                        break;
                    }
                }

                rightDirection = false;
                upDirection = true;
                if (rowD > 0)
                {
                    if (typeD[rowD - 1, colD] == 0)
                    {
                        rowD--;
                    }
                }
            }

            if (upDirection)
            {
                while ((typeD[rowD, colD] == 0) && (number <= N * N))
                {
                    typeD[rowD, colD] = number;
                    number++;

                    if ((rowD > 0) && (typeD[rowD - 1, colD] == 0))
                    {
                        rowD--;
                    }
                    else
                    {
                        break;
                    }
                }

                upDirection = false;
                leftDirection = true;
                if (colD > 0)
                {
                    if (typeD[rowD, colD - 1] == 0)
                    {
                        colD--;
                    }
                }
            }

            if (leftDirection)
            {
                while ((typeD[rowD, colD] == 0) && (number <= N * N))
                {
                    typeD[rowD, colD] = number;
                    number++;

                    if ((colD > 0) &&  (typeD[rowD, colD - 1] == 0))
                    {
                        colD--;
                    }
                    else
                    {
                        break;
                    }
                }

                leftDirection = false;
                downDirection = true;
                if (rowD < N - 1)
                {
                    if (typeD[rowD + 1, colD] == 0)
                    {
                        rowD++;
                    }
                }
            }
        }

        //print all types
        PrintMatrix(typeA);
        PrintMatrix(typeB);
        PrintMatrix(typeC);
        PrintMatrix(typeD);
    }
}