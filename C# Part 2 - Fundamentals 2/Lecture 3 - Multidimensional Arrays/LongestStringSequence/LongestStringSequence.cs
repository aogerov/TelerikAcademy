//We are given a matrix of strings of size N x M.
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 

using System;
using System.Collections.Generic;
using System.Text;

class LongestStringSequence
{
    static string[,] str;
    static List<Result> results;

    struct Position
    {
        private int row;
        private int col;

        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    struct Result
    {
        private int length;
        private List<Position> position;

        public Result(int length, List<Position> position)
        {
            this.length = length;
            this.position = position;
        }

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public List<Position> Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
    }

    static void CalculateUpRight(int row, int col)
    {
        string currentPosition = str[row, col];
        int length = 1;
        List<Position> position = new List<Position>();
        position.Add(new Position(row, col));

        while ((row > 0) && (col < str.GetLength(1) - 1))
        {
            row--;
            col++;

            if (currentPosition.Equals(str[row,col]))
            {
                length++;
                position.Add(new Position(row, col));
            }
        }

        results.Add(new Result(length, position));
    }

    static void CalculateRight(int row, int col)
    {
        string currentPosition = str[row, col];
        int length = 1;
        List<Position> position = new List<Position>();
        position.Add(new Position(row, col));

        while (col < str.GetLength(1) - 1)
        {
            col++;

            if (currentPosition.Equals(str[row, col]))
            {
                length++;
                position.Add(new Position(row, col));
            }
        }

        results.Add(new Result(length, position));
    }

    static void CalculateDownRight(int row, int col)
    {
        string currentPosition = str[row, col];
        int length = 1;
        List<Position> position = new List<Position>();
        position.Add(new Position(row, col));

        while ((row < str.GetLength(0) - 1) && (col < str.GetLength(1) - 1))
        {
            row++;
            col++;

            if (currentPosition.Equals(str[row, col]))
            {
                length++;
                position.Add(new Position(row, col));
            }
        }

        results.Add(new Result(length, position));
    }

    static void CalculateDown(int row, int col)
    {
        string currentPosition = str[row, col];
        int length = 1;
        List<Position> position = new List<Position>();
        position.Add(new Position(row, col));

        while (row < str.GetLength(0) - 1)
        {
            row++;

            if (currentPosition.Equals(str[row, col]))
            {
                length++;
                position.Add(new Position(row, col));
            }
        }

        results.Add(new Result(length, position));
    }

    static void Main()
    {
        //N & M input reader
        Console.Write("Enter the rows count of the matrix, N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter the columns count of the matrix, M: ");
        int M = int.Parse(Console.ReadLine());

        //test values
        //int N = 3;
        //int M = 4;
        //str = new string[N, M];
        //str[0,0] = "ha";
        //str[0,1] = "fifi";
        //str[0,2] = "ho";
        //str[0,3] = "hi";
        //str[1,0] = "fo";
        //str[1,1] = "ha";
        //str[1,2] = "hi";
        //str[1,3] = "xx";
        //str[2,0] = "xxx";
        //str[2,1] = "ho";
        //str[2,2] = "ha";
        //str[2,3] = "xx";
       
        //check if N or M are lower than 2
        if ((N < 2) || (M < 2))
        {
            Console.WriteLine("\r\nWrong input! N & M has to be at least 2.");
            return;
        }

        //matrix initialization
        Console.WriteLine("Enter the strings of the matrix:");
        str = new string[N, M];

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("Index ({0},{1}): ", row, col);
                str[row, col] = Console.ReadLine();
            }
        }

        //calculate appearances
        results = new List<Result>();

        for (int row = 0; row < str.GetLength(0); row++)
        {
            for (int col = 0; col < str.GetLength(1); col++)
            {
                CalculateUpRight(row, col);
                CalculateRight(row, col);
                CalculateDownRight(row, col);
                CalculateDown(row, col);
            }
        }

        //locate longest sequence
        Result result = new Result();
        int sequenceLength = 0;

        foreach (var res in results)
        {
            if (sequenceLength < res.Length)
            {
                sequenceLength = res.Length;
                result = res;
            }
        }

        //print full matrix
        Console.WriteLine("\r\nFull matrix:");

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write(str[row, col]);

                if (col < M - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        //print longest sequence
        List<Position> output = result.Position;
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("\r\nLongest sequence visualization:");

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {

                if (output.Contains(new Position(row, col)))
                {
                    sb.Append(str[row, col]);
                }
                else
                {
                    foreach (var ch in str[row,col])
                    {
                        sb.Append(" ");
                    }
                }

                if (col < M - 1)
                {
                    sb.Append(" ");
                }
            }
            sb.Append("\r\n");
        }

        Console.WriteLine(sb);
    }
}