using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

class GameOfTrollsVisual
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
    static int destroyedTowers;
    static int currentScore;
    static int finalScore;
    static int bypassCounter;
    static int bypassMax;
    static bool colLeft;
    static bool colRight;
    static bool rowUp;
    static bool rowDown;
    static bool endOfProgram;
    static int fileCounter;
    static StringBuilder output = new StringBuilder();
    struct Towers
    {
        public int towerRow, towerCol;
        public Towers(int towerRow, int towerCol)
        {
            this.towerRow = towerRow;
            this.towerCol = towerCol;
        }
    }
    static HashSet<Towers> towersToDestroyQueue = new HashSet<Towers>();

    static void InputReader()
    {
        string input;
        string[] rowRead;

        Console.Write("Count of turns, C = ");
        input = Console.ReadLine();
        C = int.Parse(input);

        Console.Write("Size of the matrix, N = ");
        input = Console.ReadLine();
        N = int.Parse(input);
        matrix = new int[N, N];

        Console.WriteLine("Input the numbers like on the algorithm part...");
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

    static void StartProgram()
    {
        PartBeginn();
        ButtonAuto();
        ButtonPause();
        ButtonPrevious();
        ButtonNext();
        PartBetweenButtonsAndFields();
        FieldPutOrTake();
        FieldCurrentDestroyedTowers();
        FieldCurrentScore();
        FieldTurnsCounter();
        FieldAllDestroyedTowers();
        FieldFinalScore();
        PartMiddle();
        PartEnd();
        TextWriter writer = new StreamWriter("GameOfTrolls.html");
        writer.Write(output);
        writer.Close();
        VariablePreparation();
        System.Diagnostics.Process.Start("GameOfTrolls.html");
    }

    static void BypassOptimiser()
    {
        int maxPositions = 20000;
        bypassMax = maxPositions / ((C + N) / 2);
    }

    static void MatrixLengthOne()
    {
        while ((matrix[0, 0] > 0) && (fileCounter < C))
        {
            matrix[0, 0]--;
            positionRow = 0;
            positionCol = 0;
            action = 3;
            currentScore = 1;
            HtmlOutputFile();
            VariablePreparation();
        }
        while (fileCounter < C)
        {
            PrintEmptyMoves(fileCounter);
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

    static void SetPointsAndDestroy()
    {
        currentPosition = matrix[positionRow, positionCol];
        currentScore += currentPosition;

        if (colLeft && (currentPosition == matrix[positionRow, positionCol - 1]))
        {
            towersToDestroyQueue.Add(new Towers(positionRow, positionCol - 1));
            currentScore += currentPosition;
        }
        if (colRight && (currentPosition == matrix[positionRow, positionCol + 1]))
        {
            towersToDestroyQueue.Add(new Towers(positionRow, positionCol + 1));
            currentScore += currentPosition;
        }
        if (rowUp && (currentPosition == matrix[positionRow - 1, positionCol]))
        {
            towersToDestroyQueue.Add(new Towers(positionRow - 1, positionCol));
            currentScore += currentPosition;
        }
        if (rowDown && (currentPosition == matrix[positionRow + 1, positionCol]))
        {
            towersToDestroyQueue.Add(new Towers(positionRow + 1, positionCol));
            currentScore += currentPosition;
        }
    }

    static void PutOrTake()
    {
        if ((action == 1))
        {
            matrix[positionRow, positionCol]++;
            ValidatePosition(positionRow, positionCol);
            SetPointsAndDestroy();
        }
        if (action == 2)
        {
            matrix[positionRow, positionCol]--;
            ValidatePosition(positionRow, positionCol);
            SetPointsAndDestroy();
        }
        if ((action == 3) && (matrix[positionRow, positionCol] > 0))
        {
            matrix[positionRow, positionCol]--;
            currentScore++;
        }
    }

    static void PartBeginn()
    {
        output.Append("<!DOCTYPE html>\r\n");
        output.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
        output.Append("<head>\r\n");
        output.Append("\t<title>Game Of Trolls</title>\r\n");
        output.Append("\t<link type=\"text/css\" rel=\"stylesheet\" href=\"styles.css\" />\r\n");
        output.Append("</head>\r\n");
        output.Append("<body>\r\n");
        output.Append("\t<header>\r\n");
        output.Append("\t\t<form>\r\n");
        output.Append("\t\t\t<section>\r\n");
    }

    static void ButtonAuto()
    {
        output.Append("\t\t\t\t<input type=\"button\" value=\"Auto\"");
        if (fileCounter >= C)
        {
            output.Append(" disabled=\"disabled\"");
        }
        output.Append(" />\r\n");
    }

    static void ButtonPause()
    {
        output.Append("\t\t\t\t<input type=\"button\" value=\"Pause\"");
        if (fileCounter >= C)
        {
            output.Append(" disabled=\"disabled\"");
        }
        output.Append(" />\r\n");
    }

    static void ButtonPrevious()
    {
        output.Append("\t\t\t\t<input type=\"button\" value=\"Previous\"");
        output.Append(" onclick=\"location.href='GameOfTrolls");
        if (fileCounter > 1)
        {
            output.Append(fileCounter - 1);
        }
        output.Append(".html'\"");
        if (fileCounter < 1)
        {
            output.Append(" disabled=\"disabled\"");
        }
        output.Append(" />\r\n");
    }

    static void ButtonNext()
    {
        output.Append("\t\t\t\t<input type=\"button\" value=\"Next\"");
        output.Append(" onclick=\"location.href='GameOfTrolls");
        output.Append(fileCounter + 1);
        output.Append(".html'\"");
        if (fileCounter >= C)
        {
            output.Append(" disabled=\"disabled\"");
        }
        output.Append(" />\r\n");
    }

    static void PartBetweenButtonsAndFields()
    {
        output.Append("\t\t\t</section>\r\n");
        output.Append("\t\t\t<br />\r\n");
        output.Append("\t\t\t<section class=\"input\">\r\n");
    }

    static void FieldPutOrTake()
    {
        output.Append("\t\t\t\t<label class=\"labels\" for=\"putTake\">\r\n");
        output.Append("\t\t\t\t\tPut or Take:\r\n");
        output.Append("\t\t\t\t\t<input type=\"text\" class=\"");
        if (action == 1)
        {
            output.Append("inputsPut");
            output.Append("\" id=\"putTake\" value=\"");
            output.Append("put  ");
            output.Append(positionRow);
            output.Append("  ");
            output.Append(positionCol);
        }
        else if ((action == 2) || (action == 3))
        {
            output.Append("inputsTake");
            output.Append("\" id=\"putTake\" value=\"");
            output.Append("take  ");
            output.Append(positionRow);
            output.Append("  ");
            output.Append(positionCol);
        }
        else
        {
            output.Append("inputs");
            output.Append("\" id=\"putTake\" value=\"");
        }
        output.Append("\" readonly=\"readonly\" />\r\n");
        output.Append("\t\t\t\t</label>\r\n");
    }

    static void FieldCurrentDestroyedTowers()
    {
        output.Append("\t\t\t\t<label class=\"labels\" for=\"currentTowers\">\r\n");
        output.Append("\t\t\t\t\tCurrent destroyed towers:\r\n");
        output.Append("\t\t\t\t\t<input type=\"text\" class=\"inputs\" id=\"currentTowers\" value=\"");
        if (towersToDestroyQueue.Count > 0)
        {
            output.Append(towersToDestroyQueue.Count + 1);
        }
        else
        {
            output.Append("0");
        }
        output.Append("\" readonly=\"readonly\" />\r\n");
        output.Append("\t\t\t\t</label>\r\n");
    }

    static void FieldCurrentScore()
    {
        output.Append("\t\t\t\t<label class=\"labels\" for=\"turn\">\r\n");
        output.Append("\t\t\t\t\tCurrent score:\r\n");
        output.Append("\t\t\t\t<input type=\"text\" class=\"inputs\" id=\"turn\" value=\"");
        output.Append(currentScore);
        output.Append("\" readonly=\"readonly\" />\r\n");
        output.Append("\t\t\t\t</label>\r\n");
        output.Append("\t\t\t\t<br />\r\n");
        output.Append("\t\t\t\t<br />\r\n");
    }

    static void FieldTurnsCounter()
    {
        output.Append("\t\t\t\t<label class=\"labels\" for=\"turns\">\r\n");
        output.Append("\t\t\t\t\tTurns counter:\r\n");
        output.Append("\t\t\t\t\t<input type=\"text\" class=\"inputs\" id=\"turns\" value=\"");
        output.Append(fileCounter);
        output.Append(" of ");
        output.Append(C);
        output.Append("\" readonly=\"readonly\" />\r\n");
        output.Append("\t\t\t\t</label>\r\n");
    }

    static void FieldAllDestroyedTowers()
    {
        if (towersToDestroyQueue.Count > 0)
        {
            destroyedTowers += towersToDestroyQueue.Count + 1;
        }
        output.Append("\t\t\t\t<label class=\"labels\" for=\"allTowers\">\r\n");
        output.Append("\t\t\t\t\tAll destroyed towers:\r\n");
        output.Append("\t\t\t\t\t<input type=\"text\" class=\"inputs\" id=\"allTowers\" value=\"");
        output.Append(destroyedTowers);
        output.Append("\" readonly=\"readonly\" />\r\n");
        output.Append("\t\t\t\t</label>\r\n");
    }

    static void FieldFinalScore()
    {
        finalScore += currentScore;
        output.Append("\t\t\t\t<label class=\"labels\" for=\"final\">\r\n");
        output.Append("\t\t\t\t\tFinal score:\r\n");
        output.Append("\t\t\t\t\t<input type=\"text\" class=\"inputs\" id=\"final\" value=\"");
        output.Append(finalScore);
        output.Append("\" readonly=\"readonly\" />\r\n");
        output.Append("\t\t\t\t</label>\r\n");
    }

    static void PartMiddle()
    {
        output.Append("\t\t\t</section>\r\n");
        output.Append("\t\t</form>\r\n");
        output.Append("\t</header>\r\n");
        output.Append("\t<section id=\"matrix\">\r\n");
        output.Append("\t\t<table>\r\n");
        if (action == 1)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                output.Append("\t\t\t<tr>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == positionRow) && (col == positionCol))
                    {
                        output.Append("<td class=\"towerPut\">");
                        output.Append(matrix[row, col]);
                    }
                    else if (towersToDestroyQueue.Contains(new Towers(row, col)))
                    {
                        output.Append("<td class=\"towers\">");
                        output.Append(matrix[row, col]);
                        towersToDestroyQueue.Remove(new Towers(row, col));
                    }
                    else if (matrix[row, col] == 0)
                    {
                        output.Append("<td class=\"destroyed\">");
                    }
                    else
                    {
                        output.Append("<td>");
                        output.Append(matrix[row, col]);
                    }
                    output.Append("</td>");
                }
                output.Append("</tr>\r\n");
            }
            {

            }
        }
        else if ((action == 2) || (action == 3))
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                output.Append("\t\t\t<tr>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == positionRow) && (col == positionCol))
                    {
                        output.Append("<td class=\"towerTake\">");
                        output.Append(matrix[row, col]);
                    }
                    else if (towersToDestroyQueue.Contains(new Towers(row, col)))
                    {
                        output.Append("<td class=\"towers\">");
                        output.Append(matrix[row, col]);
                        towersToDestroyQueue.Remove(new Towers(row, col));
                    }
                    else if (matrix[row, col] == 0)
                    {
                        output.Append("<td class=\"destroyed\">");
                    }
                    else
                    {
                        output.Append("<td>");
                        output.Append(matrix[row, col]);
                    }
                    output.Append("</td>");
                }
                output.Append("</tr>\r\n");
            }
        }
        else
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                output.Append("\t\t\t<tr>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output.Append("<td>");
                    output.Append(matrix[row, col]);
                    output.Append("</td>");
                }
                output.Append("</tr>\r\n");
            }
        }
        output.Append("\t\t</table>\r\n");
        output.Append("\t</section>\r\n");
    }

    static void PartEnd()
    {
        output.Append("\t<section id=\"trol\">\r\n");
        output.Append("\t\t<img src=\"trol.png\" alt=\"trol.png\" />\r\n");
        output.Append("\t</section>\r\n");
        output.Append("</body>\r\n");
        output.Append("</html>\r\n");
    }

    static void HtmlOutputFile()
    {
        if (positionRow == -1 || positionCol == -1)
        {
            endOfProgram = true;
            return;
        }
        fileCounter++;
        PartBeginn();
        ButtonAuto();
        ButtonPause();
        ButtonPrevious();
        ButtonNext();
        PartBetweenButtonsAndFields();
        FieldPutOrTake();
        FieldCurrentDestroyedTowers();
        FieldCurrentScore();
        FieldTurnsCounter();
        FieldAllDestroyedTowers();
        FieldFinalScore();
        PartMiddle();
        PartEnd();
        TextWriter writer = new StreamWriter("GameOfTrolls" + fileCounter + ".html");
        writer.Write(output);
        writer.Close();
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

    static void PrintEmptyMoves(int turnsCounter)
    {
        for (int turnCounter = 0; turnCounter <= turnsCounter; turnCounter++)
        {
            if (turnCounter % 2 == 0)
            {
                matrix[0, 0]++;
                positionRow = 0;
                positionCol = 0;
                action = 1;
                currentScore = 1;
                HtmlOutputFile();
                VariablePreparation();
            }
            else
            {
                matrix[0, 0]--;
                positionRow = 0;
                positionCol = 0;
                action = 2;
                currentScore = 1;
                HtmlOutputFile();
                VariablePreparation();
            }
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
        currentScore = 0;
        bypassCounter = 0;
        output.Clear();
    }

    static void Main()
    {
        InputReader();
        StartProgram();
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
                    HtmlOutputFile();
                    DestroyTowers();
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
            HtmlOutputFile();
            DestroyTowers();
            VariablePreparation();

            if (endOfProgram)
            {
                PrintEmptyMoves(C - turnsCounter);
                return;
            }
        }
    }
}