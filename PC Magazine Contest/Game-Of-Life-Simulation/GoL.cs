using System;
using System.Text;
using System.Threading;

class GoL
{
    static int T;
    static int N;
    static int V;
    static char[,] matrix;
    static int turnsCounter;
    static int aliveCellsCount;
    static int startFoodCount;
    static int endFoodCount;

    static void InputReader()
    {
        T = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());
        V = int.Parse(Console.ReadLine());
        matrix = new char[N, N];
        turnsCounter = 0;

        for (int row = 0; row < N; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < N; col++)
            {
                matrix[row, col] = line[col];
                if (line[col] == 'F')
                {
                    startFoodCount++;
                }
            }
        }
    }

    static int InsideCellsCount(int row, int col)
    {
        int aliveCellsCount = 0;

        if (matrix[row - 1, col] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row + 1, col] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row, col - 1] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row, col + 1] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row - 1, col - 1] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row - 1, col + 1] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row + 1, col - 1] == '+')
        {
            aliveCellsCount++;
        }
        if (matrix[row + 1, col + 1] == '+')
        {
            aliveCellsCount++;
        }

        return aliveCellsCount;
    }

    static int FrameCellsCount(int row, int col)
    {
        int aliveCellsCount = 0;
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        bool upLeft = false;
        bool upRight = false;
        bool downLeft = false;
        bool downRight = false;

        if (row > 0)
        {
            up = true;
        }
        if (row < N - 1)
        {
            down = true;
        }
        if (col > 0)
        {
            left = true;
        }
        if (col < N - 1)
        {
            right = true;
        }
        if ((row > 0) && (col > 0))
        {
            upLeft = true;
        }
        if ((row > 0) && (col < N - 1))
        {
            upRight = true;
        }
        if ((row < N - 1) && (col > 0))
        {
            downLeft = true;
        }
        if ((row < N - 1) && (col < N - 1))
        {
            downRight = true;
        }

        if (up && (matrix[row - 1, col] == '+'))
        {
            aliveCellsCount++;
        }
        if (down && (matrix[row + 1, col] == '+'))
        {
            aliveCellsCount++;
        }
        if (left && (matrix[row, col - 1] == '+'))
        {
            aliveCellsCount++;
        }
        if (right && (matrix[row, col + 1] == '+'))
        {
            aliveCellsCount++;
        }
        if (upLeft && (matrix[row - 1, col - 1] == '+'))
        {
            aliveCellsCount++;
        }
        if (upRight && (matrix[row - 1, col + 1] == '+'))
        {
            aliveCellsCount++;
        }
        if (downLeft && (matrix[row + 1, col - 1] == '+'))
        {
            aliveCellsCount++;
        }
        if (downRight && (matrix[row + 1, col + 1] == '+'))
        {
            aliveCellsCount++;
        }

        return aliveCellsCount;
    }

    static int AliveCellsCount(int row, int col)
    {
        int aliveCellsCount = 0;

        if ((row > 0) && (row < N - 1) && (col > 0) && (col < N - 1))
        {
            aliveCellsCount = InsideCellsCount(row, col);
        }
        else
        {
            aliveCellsCount = FrameCellsCount(row, col);
        }

        return aliveCellsCount;
    }

    static void NextTurn()
    {
        char[,] nextTurn = new char[N, N];
        int aliveCellsCount;
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                aliveCellsCount = AliveCellsCount(row, col);

                if (matrix[row, col] == '+')
                {
                    if ((aliveCellsCount == 2) || (aliveCellsCount == 3))
                    {
                        nextTurn[row, col] = '+';
                    }
                    else
                    {
                        nextTurn[row, col] = '0';
                    }
                }
                else if (matrix[row, col] == '0')
                {
                    if (aliveCellsCount == 3)
                    {
                        nextTurn[row, col] = '+';
                    }
                    else
                    {
                        nextTurn[row, col] = '0';
                    }
                }
                else if (matrix[row, col] == 'F')
                {
                    if (aliveCellsCount == 3)
                    {
                        nextTurn[row, col] = '+';
                    }
                    else
                    {
                        nextTurn[row, col] = 'F';
                    }
                }
            }
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                matrix[row, col] = nextTurn[row, col];
            }
        }

        turnsCounter++;
    }

    static void OutputWriter()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Turn {0} of {1}:\r\n", turnsCounter, T);

        StringBuilder output = new StringBuilder();
        output.EnsureCapacity(N * N);

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (matrix[row, col] != '0')
                {
                    output.Append(matrix[row, col]);
                }
                else
                {
                    output.Append(' ');
                }
            }
            output.Append("\r\n");
        }

        Console.WriteLine(output);
        Thread.Sleep(100);
    }

    static void CountAliveCellsAndFood()
    {
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (matrix[row, col] == '+')
                {
                    aliveCellsCount++;
                }
                else if (matrix[row, col] == 'F')
                {
                    endFoodCount++;
                }
            }
        }

    }

    static void Main()
    {
        InputReader();
        OutputWriter();

        for (int turn = 0; turn < T; turn++)
        {
            NextTurn();
            OutputWriter();
        }
        OutputWriter();
        CountAliveCellsAndFood();
        Console.WriteLine("Alive cells = {0}\r\nEaten cells = {1}\r\nTotal = {2}", aliveCellsCount, startFoodCount - endFoodCount, aliveCellsCount + startFoodCount - endFoodCount);
        Console.CursorVisible = true;
    }
}