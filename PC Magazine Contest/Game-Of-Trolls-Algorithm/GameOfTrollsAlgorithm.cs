using System;

class GameOfTrollsAlgorithm
{
    static int C;
    static int N;
    static int[,] matrix;
    static int positionRow;
    static int positionCol;
    static int putValue;
    static int takeValue;
    static int singlePositonValue;
    static int maxValue;
    static int currentPosition;
    static int action;
    static int bypassCounter;
    static int bypassMax;
    static bool colLeft;
    static bool colRight;
    static bool rowUp;
    static bool rowDown;
    static bool endOfProgram;

    static void InputReader()
    {
        string input;
        string[] rowRead;

        input = Console.ReadLine();
        C = int.Parse(input);

        input = Console.ReadLine();
        N = int.Parse(input);
        matrix = new int[N, N];

        for (int row = 0; row < N; row++)
        {
            input = Console.ReadLine();
            rowRead = input.Split(' ');
            for (int col = 0; col < N; col++)
            {
                matrix[row, col] = int.Parse(rowRead[col]);
            }
        }
    }

    static void BypassOptimiser()
    {
        int maxPositions = 20000;
        bypassMax = maxPositions / ((C + N) / 2);
    }

    static void MatrixLengthOne()
    {
        while ((matrix[0,0] > 0) && (C > 0))
        {
            Console.WriteLine("take 0 0");
            matrix[0, 0]--;
            C--;
        }
        while (C > 0)
        {
            PrintEmptyMoves(C);
            C--;
        }
    }

    static void ValidatePosition(int row, int col)
    {
        if (row - 1 < 0)
        {
            rowUp = false;
        }
        else
        {
            rowUp = true;
        }
        if (row + 1 > N - 1)
        {
            rowDown = false;
        }
        else
        {
            rowDown = true;
        }
        if (col - 1 < 0)
        {
            colLeft = false;
        }
        else
        {
            colLeft = true;
        }
        if (col + 1 > N - 1)
        {
            colRight = false;
        }
        else
        {
            colRight = true;
        }
    }

    static void CheckPutValue(int row, int col)
    {
        currentPosition = matrix[row, col] + 1;
        putValue = 0;

        if (currentPosition == matrix[row, col - 1])
        {
            putValue += matrix[row, col - 1];
        }
        if (currentPosition == matrix[row, col + 1])
        {
            putValue += matrix[row, col + 1];
        }
        if (currentPosition == matrix[row - 1, col])
        {
            putValue += matrix[row - 1, col];
        }
        if (currentPosition == matrix[row + 1, col])
        {
            putValue += matrix[row + 1, col];
        }
        if (putValue > 0)
        {
            putValue += currentPosition;
        }
    }

    static void CheckTakeValue(int row, int col)
    {
        currentPosition = matrix[row, col] - 1;
        takeValue = 0;

        if (currentPosition == matrix[row, col - 1])
        {
            takeValue += matrix[row, col - 1];
        }
        if (currentPosition == matrix[row, col + 1])
        {
            takeValue += matrix[row, col + 1];
        }
        if (currentPosition == matrix[row - 1, col])
        {
            takeValue += matrix[row - 1, col];
        }
        if (currentPosition == matrix[row + 1, col])
        {
            takeValue += matrix[row + 1, col];
        }
        if (takeValue > 0)
        {
            takeValue += currentPosition;
        }
    }

    static void CheckPutValueFrame(int row, int col)
    {
        currentPosition = matrix[row, col] + 1;
        putValue = 0;

        if (colLeft && (currentPosition == matrix[row, col - 1]))
        {
            putValue += matrix[row, col - 1];
        }
        if (colRight && (currentPosition == matrix[row, col + 1]))
        {
            putValue += matrix[row, col + 1];
        }
        if (rowUp && (currentPosition == matrix[row - 1, col]))
        {
            putValue += matrix[row - 1, col];
        }
        if (rowDown && (currentPosition == matrix[row + 1, col]))
        {
            putValue += matrix[row + 1, col];
        }
        if (putValue > 0)
        {
            putValue += currentPosition;
        }
    }

    static void CheckTakeValueFrame(int row, int col)
    {
        currentPosition = matrix[row, col] - 1;
        takeValue = 0;

        if (colLeft && (currentPosition == matrix[row, col - 1]))
        {
            takeValue += matrix[row, col - 1];
        }
        if (colRight && (currentPosition == matrix[row, col + 1]))
        {
            takeValue += matrix[row, col + 1];
        }
        if (rowUp && (currentPosition == matrix[row - 1, col]))
        {
            takeValue += matrix[row - 1, col];
        }
        if (rowDown && (currentPosition == matrix[row + 1, col]))
        {
            takeValue += matrix[row + 1, col];
        }
        if (takeValue > 0)
        {
            takeValue += currentPosition;
        }
    }

    static void SetMaxValue(int row, int col)
    {
        if ((putValue > 0) || (takeValue > 0))
        {
            if (maxValue < putValue)
            {
                maxValue = putValue;
                positionRow = row;
                positionCol = col;
                action = 1;
            }
            if (maxValue < takeValue)
            {
                maxValue = takeValue;
                positionRow = row;
                positionCol = col;
                action = 2;
            }
        }
        else if ((maxValue == 0) && (singlePositonValue < matrix[row, col]))
        {
            singlePositonValue = matrix[row, col];
            positionRow = row;
            positionCol = col;
            action = 3;
        }
    }

    static void PutOrTake()
    {
        if ((action == 1))
        {
            matrix[positionRow, positionCol]++;
        }
        if (action == 2)
        {
            matrix[positionRow, positionCol]--;
        }
        if ((action == 3) && (matrix[positionRow, positionCol] > 0))
        {
            matrix[positionRow, positionCol]--;
        }
    }

    static void DestroyTowers()
    {
        if (positionRow == -1 || positionCol == -1)
        {
            endOfProgram = true;
            return;
        }
        ValidatePosition(positionRow, positionCol);

        if ((action == 1) || (action == 2))
        {
            if (colLeft && (matrix[positionRow, positionCol] == matrix[positionRow, positionCol - 1]))
            {
                matrix[positionRow, positionCol - 1] = 0;
            }
            if (colRight && (matrix[positionRow, positionCol] == matrix[positionRow, positionCol + 1]))
            {
                matrix[positionRow, positionCol + 1] = 0;
            }
            if (rowUp && (matrix[positionRow, positionCol] == matrix[positionRow - 1, positionCol]))
            {
                matrix[positionRow - 1, positionCol] = 0;
            }
            if (rowDown && (matrix[positionRow, positionCol] == matrix[positionRow + 1, positionCol]))
            {
                matrix[positionRow + 1, positionCol] = 0;
            }
            matrix[positionRow, positionCol] = 0;
        }
    }

    static void PrintOutput()
    {
        if (((action == 1)) && (positionRow >= 0))
        {
            Console.WriteLine("put {0} {1}", positionRow, positionCol);
        }
        else if (((action == 2) || (action == 3)) && (positionRow >= 0))
        {
            Console.WriteLine("take {0} {1}", positionRow, positionCol);
        }
    }

    static void PrintEmptyMoves(int turnsCounter)
    {
        if (turnsCounter % 2 == 0)
        {
            Console.WriteLine("put 0 0");
        }
        else
        {
            Console.WriteLine("take 0 0");
        }
    }

    static void VariablePreparation()
    {
        positionRow = -1;
        positionCol = -1;
        putValue = 0;
        takeValue = 0;
        singlePositonValue = 0;
        maxValue = 0;
        currentPosition = 0;
        action = 0;
        bypassCounter = 0;
    }

    static void Main()
    {
        InputReader();
        BypassOptimiser();
        if (N == 1)
        {
            MatrixLengthOne();
            return;
        }

        for (int turnsCounter = 1; turnsCounter <= C; turnsCounter++)
        {
            for (int row = 0; row < matrix.GetLength(0); row += matrix.GetLength(0) - 1)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        continue;
                    }
                    ValidatePosition(row, col);
                    CheckPutValueFrame(row, col);
                    CheckTakeValueFrame(row, col);
                    SetMaxValue(row, col);
                }
            }

            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col += matrix.GetLength(1) - 1)
                {
                    if (matrix[row, col] == 0)
                    {
                        continue;
                    }
                    ValidatePosition(row, col);
                    CheckPutValueFrame(row, col);
                    CheckTakeValueFrame(row, col);
                    SetMaxValue(row, col);
                }
            }

            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        continue;
                    }
                    CheckPutValue(row, col);
                    CheckTakeValue(row, col);
                    SetMaxValue(row, col);
                }

                bypassCounter++;
                if (bypassCounter == bypassMax)
                {
                    PutOrTake();
                    DestroyTowers();
                    PrintOutput();
                    VariablePreparation();
                    if (turnsCounter <= C)
                    {
                        turnsCounter++;
                        if (turnsCounter > C)
                        {
                            return;
                        }
                    }
                }
            }

            PutOrTake();
            DestroyTowers();
            PrintOutput();
            VariablePreparation();

            if (endOfProgram)
            {
                PrintEmptyMoves(turnsCounter);
            }
        }
    }
}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTrollsAlgorithm
{
    class GameOfTrollsAlgorithm
    {
        static void Main(string[] args)
        {
        }
    }
}
