using System;
using System.Collections.Generic;
using System.Text;

class Algorithm
{
    static int T;
    static int N;
    static int V;
    static char[,] matrix;

    static string gunType36;
    static string gunType43;
    static string gunType51;
    static string gunType61;
    static int gunsCount;
    static int properGunAliveCells;
    static char[,] properGun;
    static char[,] rPentomino;

    static int verticalGunsCount;
    static int horisontalGunsCount;
    static int gunsTopLeftRows;
    static int gunsTopLeftCols;
    static int gunsTopRightRows;
    static int gunsTopRightCols;
    static int gunsDownLeftRows;
    static int gunsDownLeftCols;
    static int gunsDownRightRows;
    static int gunsDownRightCols;

    static int cellsCount;
    static int aliveCellsAll;

    struct gunCoordinates
    {
        public int row;
        public int col;

        public gunCoordinates(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    struct fieldCoordinates
    {
        public int rowBeginn;
        public int rowEnd;
        public int colBeginn;
        public int colEnd;

        public fieldCoordinates(int rowBeginn, int rowEnd, int colBeginn, int colEnd)
        {
            this.rowBeginn = rowBeginn;
            this.rowEnd = rowEnd;
            this.colBeginn = colBeginn;
            this.colEnd = colEnd;
        }
    }

    struct fieldData
    {
        public int rowBeginn;
        public int rowEnd;
        public int colBeginn;
        public int colEnd;
        public int size;
        public int foodCount;
        public double ratio;

        public fieldData(int rowBeginn, int rowEnd, int colBeginn, int colEnd, int size, int foodCount, double ratio)
        {
            this.rowBeginn = rowBeginn;
            this.rowEnd = rowEnd;
            this.colBeginn = colBeginn;
            this.colEnd = colEnd;
            this.size = size;
            this.foodCount = foodCount;
            this.ratio = ratio;
        }
    }

    static Queue<gunCoordinates> gunsCoordinatesTopLeft = new Queue<gunCoordinates>();
    static Queue<gunCoordinates> gunsCoordinatesTopRight = new Queue<gunCoordinates>();
    static Queue<gunCoordinates> gunsCoordinatesDownLeft = new Queue<gunCoordinates>();
    static Queue<gunCoordinates> gunsCoordinatesDownRight = new Queue<gunCoordinates>();
    static HashSet<fieldCoordinates> fieldsCoordinates = new HashSet<fieldCoordinates>();
    static List<fieldData> fields = new List<fieldData>();

    static void InputReader()
    {
        T = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());
        V = int.Parse(Console.ReadLine());
        matrix = new char[N, N];


        for (int row = 0; row < N; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < N; col++)
            {
                matrix[row, col] = line[col];
            }
        }
    }

    static void GunTypesInitialization()
    {
        gunType36 = "                        +                                 + +                       ++      ++            ++           +   +    ++            ++++        +     +   ++              ++        +   + ++    + +                     +     +       +                      +   +                                ++                      ";
        gunType43 = "                      +                                  + +                       ++       + ++          ++          + +      ++ ++          ++++       +      +++ + ++            ++       +  +  +  +  + +                     +      ++    +                       + +                                  ++                       ";
        gunType51 = "                      +                                 ++++                       ++     ++++ ++         ++         +  +   +   ++ +++        ++++      +       +   ++ ++           ++      +      +   +++++                    +       +++   +                      +  +                                  ++                       ";
        gunType61 = "                       ++                                  + +                     +            +++       ++        ++++   ++        +++      ++++     ++++   ++        +++         ++     +  +   ++ + ++  + +                 ++++    + + ++  ++                   ++++   + ++                            +                        ";
    }

    static void CalculateGunsCount()
    {
        int width = 36;
        int height = 9;
        horisontalGunsCount = 1;
        verticalGunsCount = 1;

        while (width + 40 <= N)
        {
            width = width + 40;
            horisontalGunsCount++;
        }

        while (height + 25 <= N)
        {
            height = height + 25;
            verticalGunsCount++;
        }
    }

    static void SetGunsCountToAreas()
    {
        //Top left count
        if (horisontalGunsCount % 2 == 1)
        {
            gunsTopLeftCols = (horisontalGunsCount / 2) + 1;
        }
        else
        {
            gunsTopLeftCols = horisontalGunsCount / 2;
        }

        if (verticalGunsCount % 2 == 1)
        {
            gunsTopLeftRows = (verticalGunsCount / 2) + 1;
        }
        else
        {
            gunsTopLeftRows = verticalGunsCount / 2;
        }

        //Top right count
        gunsTopRightCols = horisontalGunsCount / 2;

        if (verticalGunsCount % 2 == 1)
        {
            gunsTopRightRows = (verticalGunsCount / 2) + 1;
        }
        else
        {
            gunsTopRightRows = verticalGunsCount / 2;
        }

        //Down left count
        if (horisontalGunsCount % 2 == 1)
        {
            gunsDownLeftCols = (horisontalGunsCount / 2) + 1;
        }
        else
        {
            gunsDownLeftCols = horisontalGunsCount / 2;

        }

        gunsDownLeftRows = verticalGunsCount / 2;

        //Down right count
        gunsDownRightCols = horisontalGunsCount / 2;
        gunsDownRightRows = verticalGunsCount / 2;
    }

    static void SetGunsTopLeftCoordinates()
    {
        int rowCoordinate = 0;
        int colCoordinate = 0;

        for (int row = 0; row < gunsTopLeftRows; row++)
        {
            int iterationColCoordinate = colCoordinate;

            for (int col = 0; col < gunsTopLeftCols; col++)
            {
                gunsCoordinatesTopLeft.Enqueue(new gunCoordinates(rowCoordinate, iterationColCoordinate));
                iterationColCoordinate = iterationColCoordinate + 40;
            }

            rowCoordinate = rowCoordinate + 25;
        }
    }

    static void SetGunsTopRightCoordinates()
    {
        int rowCoordinate = 0;
        int colCoordinate = N - 36;
        if (gunsTopRightCols > 1)
        {
            colCoordinate = colCoordinate - ((gunsTopRightCols - 1) * 40);
        }

        for (int row = 0; row < gunsTopRightRows; row++)
        {
            int iterationColCoordinate = colCoordinate;

            for (int col = 0; col < gunsTopRightCols; col++)
            {
                gunsCoordinatesTopRight.Enqueue(new gunCoordinates(rowCoordinate, iterationColCoordinate));
                iterationColCoordinate = iterationColCoordinate + 40;
            }

            rowCoordinate = rowCoordinate + 25;
        }
    }

    static void SetGunsDownLeftCoordinates()
    {
        int rowCoordinate = N - 9;
        if (gunsDownLeftRows > 1)
        {
            rowCoordinate = rowCoordinate - ((gunsDownLeftRows - 1) * 25);
        }
        int colCoordinate = 0;

        for (int row = 0; row < gunsDownLeftRows; row++)
        {
            int iterationColCoordinate = colCoordinate;

            for (int col = 0; col < gunsDownLeftCols; col++)
            {
                gunsCoordinatesDownLeft.Enqueue(new gunCoordinates(rowCoordinate, iterationColCoordinate));
                iterationColCoordinate = iterationColCoordinate + 40;
            }

            rowCoordinate = rowCoordinate + 25;
        }
    }

    static void SetGunsDownRightCoordinates()
    {
        int rowCoordinate = N - 9;
        if (gunsDownRightRows > 1)
        {
            rowCoordinate = rowCoordinate - ((gunsDownRightRows - 1) * 25);
        }
        int colCoordinate = N - 36;
        if (gunsDownRightCols > 1)
        {
            colCoordinate = colCoordinate - ((gunsDownRightCols - 1) * 40);
        }

        for (int row = 0; row < gunsDownRightRows; row++)
        {
            int iterationColCoordinate = colCoordinate;

            for (int col = 0; col < gunsDownRightCols; col++)
            {
                gunsCoordinatesDownRight.Enqueue(new gunCoordinates(rowCoordinate, iterationColCoordinate));
                iterationColCoordinate = iterationColCoordinate + 40;
            }

            rowCoordinate = rowCoordinate + 25;
        }
    }

    static void SetCrossFieldsCoordinates()
    {
        //Center
        int rowBeginn = 11;
        if (gunsTopLeftRows > 1)
        {
            rowBeginn = rowBeginn + ((gunsTopLeftRows - 1) * 25);
        }
        int rowEnd = N - 11;
        if (gunsDownLeftRows > 1)
        {
            rowEnd = rowEnd - ((gunsDownLeftRows - 1) * 25);
        }

        int colBeginn = 0;
        int colEnd = N;

        fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn, colEnd));

        //Up
        rowBeginn = 0;
        rowEnd = 9;
        if (gunsTopLeftRows > 1)
        {
            rowEnd = rowEnd + ((gunsTopLeftRows - 1) * 25);
        }

        colBeginn = 36;
        if (gunsTopLeftCols > 1)
        {
            colBeginn = colBeginn + ((gunsTopLeftCols - 1) * 40);
        }
        colEnd = N - 36;
        if (gunsTopRightCols > 1)
        {
            colEnd = colEnd - ((gunsTopRightCols - 1) * 40);
        }

        fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn + 2, colEnd - 2));

        //Down
        rowBeginn = N - 9;
        if (gunsDownLeftRows > 1)
        {
            rowBeginn = rowBeginn - ((gunsDownLeftRows - 1) * 25);
        }
        rowEnd = N;

        colBeginn = 36;
        if (gunsDownLeftCols > 1)
        {
            colBeginn = colBeginn + ((gunsDownLeftCols - 1) * 40);
        }
        colEnd = N - 36;
        if (gunsDownRightCols > 1)
        {
            colEnd = colEnd - ((gunsDownRightCols - 1) * 40);
        }

        fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn + 2, colEnd - 2));
    }

    static void SetFieldsTopLeftCoordinates()
    {
        int rowBeginn = 11;
        int rowEnd = rowBeginn + 12;

        int colBeginn = 0;
        int colEnd = 36;
        if (gunsTopLeftCols > 1)
        {
            colEnd = colEnd + ((gunsTopLeftCols - 1) * 40);
        }

        for (int row = 1; row < gunsTopLeftRows; row++)
        {
            fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn, colEnd));
            rowBeginn = rowBeginn + 25;
            rowEnd = rowBeginn + 12;
        }
    }

    static void SetFieldsTopRightCoordinates()
    {
        int rowBeginn = 11;
        int rowEnd = rowBeginn + 12;

        int colBeginn = N - 36;
        if (gunsTopRightCols > 1)
        {
            colBeginn = colBeginn - ((gunsTopRightCols - 1) * 40);
        }
        int colEnd = N;

        for (int row = 1; row < gunsTopRightRows; row++)
        {
            fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn, colEnd));
            rowBeginn = rowBeginn + 25;
            rowEnd = rowBeginn + 12;
        }
    }

    static void SetFieldsDownLeftCoordinates()
    {
        int rowBeginn = N - 23;
        if (gunsDownLeftRows > 2)
        {
            rowBeginn = rowBeginn - ((gunsDownLeftRows - 2) * 25);
        }
        int rowEnd = rowBeginn + 12;

        int colBeginn = 0;
        int colEnd = 36;
        if (gunsDownLeftCols > 1)
        {
            colEnd = colEnd + ((gunsDownLeftCols - 1) * 40);
        }

        for (int row = 1; row < gunsDownLeftRows; row++)
        {
            fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn, colEnd));
            rowBeginn = rowBeginn + 25;
            rowEnd = rowBeginn + 12;
        }
    }

    static void SetFieldsDownRightCoordinates()
    {
        int rowBeginn = N - 23;
        if (gunsDownRightRows > 2)
        {
            rowBeginn = rowBeginn - ((gunsDownRightRows - 2) * 25);
        }
        int rowEnd = rowBeginn + 12;

        int colBeginn = N - 36;
        if (gunsDownRightCols > 1)
        {
            colBeginn = colBeginn - ((gunsDownRightCols - 1) * 40);
        }
        int colEnd = N;

        for (int row = 1; row < gunsDownRightRows; row++)
        {
            fieldsCoordinates.Add(new fieldCoordinates(rowBeginn, rowEnd, colBeginn, colEnd));
            rowBeginn = rowBeginn + 25;
            rowEnd = rowBeginn + 12;
        }
    }

    static void InitializeProperGun(string gunType)
    {
        properGun = new char[9, 36];
        int stringPosition = 0;

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 36; col++)
            {
                properGun[row, col] = gunType[stringPosition];
                stringPosition++;
            }
        }
    }

    static void SetProperGun()
    {
        int properGunsCount = 0;
        properGunsCount = properGunsCount + gunsCoordinatesTopLeft.Count;
        properGunsCount = properGunsCount + gunsCoordinatesTopRight.Count;
        properGunsCount = properGunsCount + gunsCoordinatesDownLeft.Count;
        properGunsCount = properGunsCount + gunsCoordinatesDownRight.Count;

        if (61 * properGunsCount <= V)
        {
            properGunAliveCells = 61;
            gunsCount = properGunsCount;

            InitializeProperGun(gunType61);
        }
        else if (51 * properGunsCount <= V)
        {
            properGunAliveCells = 51;
            gunsCount = properGunsCount;

            InitializeProperGun(gunType51);
        }
        else if (43 * properGunsCount <= V)
        {
            properGunAliveCells = 43;
            gunsCount = properGunsCount;

            InitializeProperGun(gunType43);
        }
        else if (36 * properGunsCount <= V)
        {
            properGunAliveCells = 36;
            gunsCount = properGunsCount;

            InitializeProperGun(gunType36);
        }
        else
        {
            properGunAliveCells = 36;
            gunsCount = V / properGunAliveCells;

            InitializeProperGun(gunType36);
        }

        V = V - (gunsCount * properGunAliveCells);

        aliveCellsAll = V;
    }

    static void WriteTopLeftGun(int rowCoordinate, int colCoordinate)
    {
        int properGunRow = 0;
        int properGunCol = 0;

        for (int row = rowCoordinate; row < rowCoordinate + 9; row++)
        {
            for (int col = colCoordinate; col < colCoordinate + 36; col++)
            {
                if (properGun[properGunRow, properGunCol] == '+')
                {
                    matrix[row, col] = '+';
                }
                properGunCol++;
            }
            properGunCol = 0;
            properGunRow++;
        }
    }

    static void WriteTopRightGun(int rowCoordinate, int colCoordinate)
    {
        int properGunRow = 0;
        int properGunCol = 35;

        for (int row = rowCoordinate; row < rowCoordinate + 9; row++)
        {
            for (int col = colCoordinate; col < colCoordinate + 36; col++)
            {
                if (properGun[properGunRow, properGunCol] == '+')
                {
                    matrix[row, col] = '+';
                }
                properGunCol--;
            }
            properGunCol = 35;
            properGunRow++;
        }
    }

    static void WriteDownLeftGun(int rowCoordinate, int colCoordinate)
    {
        int properGunRow = 8;
        int properGunCol = 0;

        for (int row = rowCoordinate; row < rowCoordinate + 9; row++)
        {
            for (int col = colCoordinate; col < colCoordinate + 36; col++)
            {
                if (properGun[properGunRow, properGunCol] == '+')
                {
                    matrix[row, col] = '+';
                }
                properGunCol++;
            }
            properGunCol = 0;
            properGunRow--;
        }
    }

    static void WriteDownRightGun(int rowCoordinate, int colCoordinate)
    {
        int properGunRow = 8;
        int properGunCol = 35;

        for (int row = rowCoordinate; row < rowCoordinate + 9; row++)
        {
            for (int col = colCoordinate; col < colCoordinate + 36; col++)
            {
                if (properGun[properGunRow, properGunCol] == '+')
                {
                    matrix[row, col] = '+';
                }
                properGunCol--;
            }
            properGunCol = 35;
            properGunRow--;
        }
    }

    static void WriteGuns()
    {
        int count = 0;
        while ((count < gunsCount) && ((gunsCoordinatesTopLeft.Count > 0) || (gunsCoordinatesTopRight.Count > 0) || (gunsCoordinatesDownLeft.Count > 0) || (gunsCoordinatesDownRight.Count > 0)))
        {
            if ((gunsCoordinatesTopLeft.Count > 0) && (count < gunsCount))
            {
                gunCoordinates gunCoordinate = gunsCoordinatesTopLeft.Dequeue();
                WriteTopLeftGun(gunCoordinate.row, gunCoordinate.col);
                count++;
            }

            if ((gunsCoordinatesTopRight.Count > 0) && (count < gunsCount))
            {
                gunCoordinates gunCoordinate = gunsCoordinatesTopRight.Dequeue();
                WriteTopRightGun(gunCoordinate.row, gunCoordinate.col);
                count++;
            }

            if ((gunsCoordinatesDownLeft.Count > 0) && (count < gunsCount))
            {
                gunCoordinates gunCoordinate = gunsCoordinatesDownLeft.Dequeue();
                WriteDownLeftGun(gunCoordinate.row, gunCoordinate.col);
                count++;
            }

            if ((gunsCoordinatesDownRight.Count > 0) && (count < gunsCount))
            {
                gunCoordinates gunCoordinate = gunsCoordinatesDownRight.Dequeue();
                WriteDownRightGun(gunCoordinate.row, gunCoordinate.col);
                count++;
            }
        }
    }

    static void FieldLeacher(int rowBeginn, int rowEnd, int colBeginn, int colEnd)
    {
        int size = (rowEnd - rowBeginn) * (colEnd - colBeginn);
        int foodCount = 0;
        double ratio = 0;

        for (int row = rowBeginn; row < rowEnd; row++)
        {
            for (int col = colBeginn; col < colEnd; col++)
            {
                if (matrix[row, col] == 'F')
                {
                    foodCount++;
                }
            }
        }

        if (foodCount > 0)
        {
            ratio = ((double)foodCount / size) * 100;
        }

        cellsCount = cellsCount + size;
        fields.Add(new fieldData(rowBeginn, rowEnd, colBeginn, colEnd, size, foodCount, ratio));
    }

    static void LeachFieldsData()
    {
        foreach (var item in fieldsCoordinates)
        {
            FieldLeacher(item.rowBeginn, item.rowEnd, item.colBeginn, item.colEnd);
        }

        foreach (var item in gunsCoordinatesTopLeft)
        {
            FieldLeacher(item.row, item.row + 9, item.col, item.col + 36);
        }

        foreach (var item in gunsCoordinatesTopRight)
        {
            FieldLeacher(item.row, item.row + 9, item.col, item.col + 36);
        }

        foreach (var item in gunsCoordinatesDownLeft)
        {
            FieldLeacher(item.row, item.row + 9, item.col, item.col + 36);
        }

        foreach (var item in gunsCoordinatesDownRight)
        {
            FieldLeacher(item.row, item.row + 9, item.col, item.col + 36);
        }
    }

    static int WriteLine(int row, int col, int position)
    {
        int operationResult = 3;

        if (position == 0)
        {
            matrix[row, col] = '+';
            matrix[row + 1, col] = '+';
            matrix[row + 2, col] = '+';
        }

        if (position == 1)
        {
            if (matrix[row - 1, col] == '+')
            {
                operationResult--;
            }
            matrix[row - 1, col] = '+';
            matrix[row, col] = '+';
            matrix[row + 1, col] = '+';
        }

        if (position == 2)
        {
            if (matrix[row - 2, col] == '+')
            {
                operationResult--;
            }
            if (matrix[row - 1, col] == '+')
            {
                operationResult--;
            }
            matrix[row - 2, col] = '+';
            matrix[row - 1, col] = '+';
            matrix[row, col] = '+';
        }

        return operationResult;
    }

    static void OverwriteFoodInFields()
    {
        fields.Sort((field1, field2) => field1.ratio.CompareTo(field2.ratio));
        fields.Reverse();

        foreach (var field in fields)
        {
            if (field.rowEnd - field.rowBeginn < 3)
            {
                goto endLoop;
            }

            if (field.foodCount > 0)
            {
                for (int row = field.rowBeginn; row < field.rowEnd; row++)
                {
                    for (int col = field.colBeginn; col < field.colEnd; col++)
                    {
                        if (matrix[row, col] == 'F')
                        {
                            if (aliveCellsAll < 3)
                            {
                                goto endLoop;
                            }
                            if (row < field.rowEnd - 2)
                            {
                                int operationResult = WriteLine(row, col, 0);
                                aliveCellsAll = aliveCellsAll - operationResult;
                            }
                            else if (row < field.rowEnd - 1)
                            {
                                int operationResult = WriteLine(row, col, 1);
                                aliveCellsAll = aliveCellsAll - operationResult;
                            }
                            else
                            {
                                int operationResult = WriteLine(row, col, 2);
                                aliveCellsAll = aliveCellsAll - operationResult;
                            }
                        }
                    }
                }
            }
        endLoop:
            if (aliveCellsAll > 0)
            {
                for (int row = field.rowBeginn; row < field.rowEnd; row++)
                {
                    for (int col = field.colBeginn; col < field.colEnd; col++)
                    {
                        if (matrix[row, col] == 'F')
                        {
                            matrix[row, col] = '+';
                            aliveCellsAll--;
                        }
                        if (aliveCellsAll == 0)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }

    static bool CheckPosition(int rowPosition, int colPosition)
    {
        bool result = true;

        if (colPosition + 3 < N)
        {
            for (int row = rowPosition; row <= rowPosition + 2; row++)
            {
                for (int col = colPosition; col <= colPosition + 3; col++)
                {
                    if (matrix[row, col] == '+')
                    {
                        result = false;
                        return result;
                    }
                }
            }
        }
        else if (colPosition + 2 < N)
        {
            for (int row = rowPosition; row <= rowPosition + 2; row++)
            {
                for (int col = colPosition; col <= colPosition + 2; col++)
                {
                    if (matrix[row, col] == '+')
                    {
                        result = false;
                        return result;
                    }
                }
            }
        }
        else if (colPosition + 1 < N)
        {
            for (int row = rowPosition; row <= rowPosition + 2; row++)
            {
                for (int col = colPosition; col <= colPosition + 1; col++)
                {
                    if (matrix[row, col] == '+')
                    {
                        result = false;
                        return result;
                    }
                }
            }
        }
        else if (colPosition == N - 1)
        {
            for (int row = rowPosition; row <= rowPosition + 2; row++)
            {
                if (matrix[row, colPosition] == '+')
                {
                    result = false;
                    return result;
                }
            }
        }

        return result;
    }

    static void WriteLines()
    {
        fields.Sort((field1, field2) => field1.size.CompareTo(field2.size));
        fields.Reverse();

        if (aliveCellsAll > 0)
        {
            foreach (var field in fields)
            {
                if (aliveCellsAll > 3)
                {
                    for (int row = field.rowBeginn; row < field.rowEnd - 2; row += 4)
                    {
                        for (int col = field.colBeginn; col < field.colEnd; col++)
                        {
                            if (matrix[row, col] == '0')
                            {
                                bool confirmPosition = CheckPosition(row, col);
                                if (confirmPosition)
                                {
                                    aliveCellsAll = aliveCellsAll - WriteLine(row, col, 0);
                                    col = col + 3;
                                }
                            }

                            if (aliveCellsAll < 3)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }

    static void FinalWrites()
    {
        foreach (var field in fields)
        {
            for (int col = field.colBeginn; col < field.colEnd; col++)
            {
                for (int row = field.rowBeginn; row < field.rowEnd; row++)
                {
                    if (aliveCellsAll == 0)
                    {
                        return;
                    }
                    if (matrix[row, col] == '0')
                    {
                        matrix[row, col] = '+';
                        aliveCellsAll--;
                    }
                }
            }
        }
    }

    static void DeadEndWrites()
    {
        if (aliveCellsAll > 0)
        {
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {
                    if (matrix[row, col] == '0')
                    {
                        matrix[row, col] = '+';
                        aliveCellsAll--;
                    }
                    if (aliveCellsAll == 0)
                    {
                        return;
                    }
                }
            }
        }
    }

    static void SetAliveCellsUnderFive()
    {
        if (V == 3)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (V == 0)
                    {
                        return;
                    }

                    if (matrix[row, col] == 'F')
                    {
                        if (((row == 0) && (col == 0)) || ((row == 0) && (col == N - 1)) || ((row == N - 1) && (col == 0)) || ((row == N - 1) && (col == N - 1)))
                        {
                            continue;
                        }

                        if (row == 0)
                        {
                            matrix[row, col] = '+';
                            matrix[row + 1, col] = '+';
                            matrix[row + 2, col] = '+';

                            V = V - 3;
                            continue;
                        }

                        if (row == N - 1)
                        {
                            matrix[row, col] = '+';
                            matrix[row - 1, col] = '+';
                            matrix[row - 2, col] = '+';

                            V = V - 3;
                            continue;
                        }

                        if (col == 0)
                        {
                            matrix[row, col] = '+';
                            matrix[row, col + 1] = '+';
                            matrix[row, col + 2] = '+';

                            V = V - 3;
                            continue;
                        }

                        if (col == N - 1)
                        {
                            matrix[row, col] = '+';
                            matrix[row, col - 1] = '+';
                            matrix[row, col - 2] = '+';

                            V = V - 3;
                            continue;
                        }

                        matrix[row - 1, col] = '+';
                        matrix[row, col] = '+';
                        matrix[row + 1, col] = '+';

                        V = V - 3;
                    }
                }
            }

            if (V == 3)
            {
                matrix[0, 1] = '+';
                matrix[1, 1] = '+';
                matrix[2, 1] = '+';

                V = V - 3;
            }
        }

        if (V == 4)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (V == 0)
                    {
                        return;
                    }

                    if (matrix[row, col] == 'F')
                    {
                        if ((row == 0) && (col == 0))
                        {

                            matrix[row, col] = '+';
                            matrix[row, col + 1] = '+';
                            matrix[row + 1, col] = '+';
                            matrix[row + 1, col + 1] = '+';

                            V = V - 4;
                            continue;
                        }

                        if (((row == 0) && (col == N - 1)) || (((row > 0) && (row < N - 1)) && (col == N - 1)))
                        {
                            matrix[row, col - 1] = '+';
                            matrix[row, col] = '+';
                            matrix[row + 1, col - 1] = '+';
                            matrix[row + 1, col] = '+';

                            V = V - 4;
                            continue;
                        }

                        if (((row == N - 1) && (col == 0)) || ((row == N - 1) && ((col > 0) && (col < N - 1))))
                        {
                            matrix[row - 1, col] = '+';
                            matrix[row - 1, col + 1] = '+';
                            matrix[row, col] = '+';
                            matrix[row, col + 1] = '+';

                            V = V - 4;
                            continue;
                        }

                        if ((row == N - 1) && (col == N - 1))
                        {
                            matrix[row - 1, col - 1] = '+';
                            matrix[row - 1, col] = '+';
                            matrix[row, col - 1] = '+';
                            matrix[row, col] = '+';

                            V = V - 4;
                            continue;
                        }

                        matrix[row, col] = '+';
                        matrix[row, col + 1] = '+';
                        matrix[row + 1, col] = '+';
                        matrix[row + 1, col + 1] = '+';

                        V = V - 4;
                    }
                }
            }

            if (V == 4)
            {
                matrix[0, 0] = '+';
                matrix[0, 1] = '+';
                matrix[1, 0] = '+';
                matrix[1, 1] = '+';

                V = V - 4;
            }
        }
    }

    static void RPentominoInitialization()
    {
        rPentomino = new char[5, 5];

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (((row == 1) && (col == 2)) || ((row == 1) && (col == 3)) || ((row == 2) && (col == 1)) || ((row == 2) && (col == 2)) || ((row == 3) && (col == 2)))
                {
                    rPentomino[row, col] = '+';
                }
                else
                {
                    rPentomino[row, col] = ' ';
                }
            }
        }
    }

    static void SetStartRPentomino()
    {
        if (V >= 5)
        {
            int position = N / 2;

            matrix[position - 1, position] = '+';
            matrix[position - 1, position + 1] = '+';
            matrix[position, position - 1] = '+';
            matrix[position, position] = '+';
            matrix[position + 1, position] = '+';

            V = V - 5;
        }
    }

    static void WriteRPentomino(int rowPosition, int colPosition)
    {
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                if (rPentomino[row, col] == '+')
                {
                    matrix[rowPosition + row - 2, colPosition + col - 2] = rPentomino[row, col];
                }
            }
        }
    }

    static bool ValidatePosition(int rowPosition, int colPosition)
    {
        bool isValid = true;

        for (int row = rowPosition - 2; row <= rowPosition + 2; row++)
        {
            for (int col = colPosition - 2; col <= colPosition + 2; col++)
            {
                if (matrix[row, col] == '+')
                {
                    isValid = false;
                    return isValid;
                }
            }
        }

        return isValid;
    }

    static void SetRPentominoOverFood()
    {
        int splitMatrix = N / 2;
        for (int row = 3; row < splitMatrix; row++)
        {
            for (int colUp = 2; colUp < N - 2; colUp++)
            {
                if (V < 5)
                {
                    return;
                }
                if (matrix[row, colUp] == 'F')
                {
                    if (ValidatePosition(row, colUp))
                    {
                        WriteRPentomino(row, colUp);
                        V = V - 5;
                    }
                }
            }

            for (int colDown = 2; colDown < N - 2; colDown++)
            {
                if (V < 5)
                {
                    return;
                }
                if (matrix[N - row, colDown] == 'F')
                {
                    if (ValidatePosition(N - row, colDown))
                    {
                        WriteRPentomino(N - row, colDown);
                        V = V - 5;
                    }
                }
            }
        }
    }

    static void SetRPentominoRandom()
    {
        if (N > 10)
        {
            int splitMatrix = N / 2;
            for (int row = 4; row < splitMatrix; row++)
            {
                for (int col = 4; col < N - 2; col++)
                {
                    bool foundSpot = false;

                    if (V < 5)
                    {
                        return;
                    }
                    if (matrix[row, col] == '0')
                    {
                        if (ValidatePosition(row, col))
                        {
                            WriteRPentomino(row, col);
                            V = V - 5;
                            foundSpot = true;
                        }
                    }

                    if (V < 5)
                    {
                        return;
                    }
                    if (matrix[N - row, col] == '0')
                    {
                        if (ValidatePosition(N - row, col))
                        {
                            WriteRPentomino(N - row, col);
                            V = V - 5;
                            foundSpot = true;
                        }
                    }

                    if (foundSpot)
                    {
                        col = col + 8;
                        foundSpot = false;
                    }
                }
            }
        }
    }

    static void SingleFoodOverwrite()
    {
        if (V == 0)
        {
            return;
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (V == 0)
                {
                    return;
                }
                if (matrix[row, col] == 'F')
                {
                    matrix[row, col] = '+';
                    V--;
                }
            }
        }
    }

    static void SetSingleLiveCells()
    {
        for (int row = N - 1; row > N - 4; row--)
        {
            if (V == 0)
            {
                return;
            }
            if (matrix[row, N - 2] != '+')
            {
                matrix[row, N - 2] = '+';
                V--;
            }
        }

        for (int col = 0; col < N; col++)
        {
            for (int row = 0; row < N; row++)
            {
                if (V == 0)
                {
                    return;
                }
                if (matrix[row, col] == '0')
                {
                    matrix[row, col] = '+';
                    V--;
                }
            }
        }
    }

    static void OutputWriter()
    {
        StringBuilder output = new StringBuilder();
        output.EnsureCapacity(N * N);

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                output.Append(matrix[row, col]);
            }
            if (row < N - 1)
            {
                output.Append("\r\n");
            }
        }

        Console.WriteLine(output);
    }

    static void Main()
    {
        //double operationTime = (DateTime.Now.Second * 1000) + DateTime.Now.Millisecond;

        InputReader();

        if ((N >= 76) && (V >= 72))
        {
            GunTypesInitialization();
            CalculateGunsCount();
            SetGunsCountToAreas();

            SetGunsTopLeftCoordinates();
            SetGunsTopRightCoordinates();
            SetGunsDownLeftCoordinates();
            SetGunsDownRightCoordinates();

            SetCrossFieldsCoordinates();
            SetFieldsTopLeftCoordinates();
            SetFieldsTopRightCoordinates();
            SetFieldsDownLeftCoordinates();
            SetFieldsDownRightCoordinates();

            SetProperGun();
            WriteGuns();

            LeachFieldsData();

            OverwriteFoodInFields();
            WriteLines();
            FinalWrites();
            DeadEndWrites();
        }
        else
        {
            SetAliveCellsUnderFive();
            RPentominoInitialization();
            SetStartRPentomino();
            SetRPentominoOverFood();
            SetRPentominoRandom();
            SingleFoodOverwrite();
            SetSingleLiveCells();
        }

        OutputWriter();

        //Console.WriteLine(((DateTime.Now.Second * 1000) + DateTime.Now.Millisecond) - operationTime);
    }
}
