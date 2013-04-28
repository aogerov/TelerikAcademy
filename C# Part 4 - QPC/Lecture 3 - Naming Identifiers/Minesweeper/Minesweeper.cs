using System;
using System.Collections.Generic;
using System.Linq;

public class Minesweeper
{
    public static void Main()
    {
        const int MAX = 35;
        int row = 0;
        int col = 0;
        int counter = 0;
        bool isDestroyed = false;
        bool isFlagged = true;
        bool isFlaggedSpecial = false;
        string command = string.Empty;

        char[,] field = CreateField();
        char[,] bombs = SetBombs();
        List<Winner> winners = new List<Winner>(6);

        do
        {
            if (isFlagged)
            {
                Console.WriteLine("Lets play \"Minesweeper\". Try your luck to find the fields without mines." +
                "Commans 'top' shows the rank list, 'restart' beginns new game, 'exit' quits the game.");

                PrintField(field);
                isFlagged = false;
            }

            Console.Write("Enter row & col : ");
            command = Console.ReadLine().Trim();

            if (command.Length >= 3)
            {
                if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                    row <= field.GetLength(0) && col <= field.GetLength(1))
                {
                    command = "turn";
                }
            }

            switch (command)
            {
                case "top":
                    Rank(winners);
                    break;

                case "restart":
                    field = CreateField();
                    bombs = SetBombs();
                    PrintField(field);
                    isDestroyed = false;
                    isFlagged = false;
                    break;

                case "exit":
                    Console.WriteLine("Goodbye!");
                    break;

                case "turn":
                    if (bombs[row, col] != '*')
                    {
                        if (bombs[row, col] == '-')
                        {
                            NextTurn(field, bombs, row, col);
                            counter++;
                        }

                        if (MAX == counter)
                        {
                            isFlaggedSpecial = true;
                        }
                        else
                        {
                            PrintField(field);
                        }
                    }
                    else
                    {
                        isDestroyed = true;
                    }

                    break;

                default:
                    Console.WriteLine("\nError! Wrong input!\n");
                    break;
            }

            if (isDestroyed)
            {
                PrintField(bombs);

                Console.Write("\nGame over! Points {0}. Enter your name: ", counter);
                string nickname = Console.ReadLine();
                Winner winner = new Winner(nickname, counter);

                if (winners.Count < 5)
                {
                    winners.Add(winner);
                }
                else
                {
                    for (int i = 0; i < winners.Count; i++)
                    {
                        if (winners[i].Points < winner.Points)
                        {
                            winners.Insert(i, winner);
                            winners.RemoveAt(winners.Count - 1);
                            break;
                        }
                    }
                }

                winners.Sort((Winner x, Winner y) => y.Name.CompareTo(x.Name));
                winners.Sort((Winner x, Winner y) => y.Points.CompareTo(x.Points));
                Rank(winners);

                field = CreateField();
                bombs = SetBombs();
                counter = 0;
                isDestroyed = false;
                isFlagged = true;
            }

            if (isFlaggedSpecial)
            {
                Console.WriteLine("\nCongratulations! You've opened all 35 fields.");
                PrintField(bombs);

                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Winner winner = new Winner(name, counter);
                winners.Add(winner);
                Rank(winners);

                field = CreateField();
                bombs = SetBombs();
                counter = 0;
                isFlaggedSpecial = false;
                isFlagged = true;
            }
        }
        while (command != "exit");

        Console.WriteLine("Made in Bulgaria!");
        Console.Read();
    }

    private static void Rank(List<Winner> points)
    {
        Console.WriteLine("\nPoints:");
        if (points.Count > 0)
        {
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Points);
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("empty ranklist!\n");
        }
    }

    private static void NextTurn(char[,] field, char[,] bombs, int row, int col)
    {
        char bombsCount = CalculateBombs(bombs, row, col);
        bombs[row, col] = bombsCount;
        field[row, col] = bombsCount;
    }

    private static void PrintField(char[,] board)
    {
        int rowLength = board.GetLength(0);
        int colLength = board.GetLength(1);

        Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
        Console.WriteLine("   ---------------------");

        for (int i = 0; i < rowLength; i++)
        {
            Console.Write("{0} | ", i);

            for (int j = 0; j < colLength; j++)
            {
                Console.Write(string.Format("{0} ", board[i, j]));
            }

            Console.Write("|");
            Console.WriteLine();
        }

        Console.WriteLine("   ---------------------\n");
    }

    private static char[,] CreateField()
    {
        int fieldRows = 5;
        int fieldCols = 10;
        char[,] field = new char[fieldRows, fieldCols];

        for (int row = 0; row < fieldRows; row++)
        {
            for (int col = 0; col < fieldCols; col++)
            {
                field[row, col] = '?';
            }
        }

        return field;
    }

    private static char[,] SetBombs()
    {
        int rows = 5;
        int cols = 10;
        char[,] field = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int k = 0; k < cols; k++)
            {
                field[i, k] = '-';
            }
        }

        List<int> bombPositions = new List<int>();

        while (bombPositions.Count < 15)
        {
            Random random = new Random();
            int nextPosition = random.Next(50);

            if (!bombPositions.Contains(nextPosition))
            {
                bombPositions.Add(nextPosition);
            }
        }

        foreach (int position in bombPositions)
        {
            int col = (position / cols);
            int row = (position % cols);

            if (row == 0 && position != 0)
            {
                col--;
                row = cols;
            }
            else
            {
                row++;
            }

            field[col, row - 1] = '*';
        }

        return field;
    }

    private static char CalculateBombs(char[,] field, int row, int col)
    {
        int counter = 0;
        int rows = field.GetLength(0);
        int cols = field.GetLength(1);

        if (row - 1 >= 0)
        {
            if (field[row - 1, col] == '*')
            {
                counter++;
            }
        }

        if (row + 1 < rows)
        {
            if (field[row + 1, col] == '*')
            {
                counter++;
            }
        }

        if (col - 1 >= 0)
        {
            if (field[row, col - 1] == '*')
            {
                counter++;
            }
        }

        if (col + 1 < cols)
        {
            if (field[row, col + 1] == '*')
            {
                counter++;
            }
        }

        if ((row - 1 >= 0) && (col - 1 >= 0))
        {
            if (field[row - 1, col - 1] == '*')
            {
                counter++;
            }
        }

        if ((row - 1 >= 0) && (col + 1 < cols))
        {
            if (field[row - 1, col + 1] == '*')
            {
                counter++;
            }
        }

        if ((row + 1 < rows) && (col - 1 >= 0))
        {
            if (field[row + 1, col - 1] == '*')
            {
                counter++;
            }
        }

        if ((row + 1 < rows) && (col + 1 < cols))
        {
            if (field[row + 1, col + 1] == '*')
            {
                counter++;
            }
        }

        return char.Parse(counter.ToString());
    }

    public class Winner
    {
        private string name;
        private int points;

        public Winner(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}