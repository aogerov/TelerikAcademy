using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    static Random randomNumber = new Random();
    static int dwarfPositionX = ((Console.WindowWidth - 2) / 2) - 1;
    static int dwarfPositionY = Console.WindowHeight - 2;
    static int counter = 0;
    static int lifes = 3;
    static int score = 0;
    struct Rock
    {
        int positionX;
        int positionY;
        char rockType;
        int rockColor;
        int rockLength;
        public Rock(int positionX, int positionY, char rockType, int rockColor, int rockLength)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.rockType = rockType;
            this.rockColor = rockColor;
            this.rockLength = rockLength;
        }
        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }
        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }
        public char RockType
        {
            get { return rockType; }
            set { rockType = value; }
        }
        public int RockColor
        {
            get { return rockColor; }
            set { rockColor = value; }
        }
        public int RockLength
        {
            get { return rockLength; }
            set { rockLength = value; }
        }
    }
    static HashSet<int> colisionPositions = new HashSet<int>();
    static Queue<Rock> rocksQueue = new Queue<Rock>();
    static Rock rock;

    static void SetTable()
    {
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write('|');
            Console.SetCursorPosition(Console.WindowWidth - 1, i);
            Console.Write('|');
        }
    }

    static void DrawDworf()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(dwarfPositionX, dwarfPositionY);
        Console.Write('(');
        Console.Write('0');
        Console.Write(')');
        colisionPositions.Clear();
        colisionPositions.Add(dwarfPositionX);
        colisionPositions.Add(dwarfPositionX + 1);
        colisionPositions.Add(dwarfPositionX + 2);
        if (dwarfPositionX == Console.WindowWidth - 4)
        {
            Console.Write('|');
        }
    }

    static void ClearDwarf()
    {
        Console.SetCursorPosition(dwarfPositionX, dwarfPositionY);
        Console.Write(' ');
        Console.Write(' ');
        Console.Write(' ');
    }

    static void GenerateColor(int color)
    {
        if (color == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        if (color == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        if (color == 2)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        if (color == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        if (color == 4)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        if (color == 5)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        if (color == 6)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    static char GenerateChar(int input)
    {
        char output = '?';
        if (input == 0)
        {
            output = '^';
        }
        if (input == 1)
        {
            output = '@';
        }
        if (input == 2)
        {
            output = '*';
        }
        if (input == 3)
        {
            output = '&';
        }
        if (input == 4)
        {
            output = '+';
        }
        if (input == 5)
        {
            output = '%';
        }
        if (input == 6)
        {
            output = '$';
        }
        if (input == 7)
        {
            output = '#';
        }
        if (input == 8)
        {
            output = '!';
        }
        if (input == 9)
        {
            output = '.';
        }
        if (input == 10)
        {
            output = ';';
        }
        if (input == 11)
        {
            output = '-';
        }
        return output;
    }

    static void RocksGenerator()
    {
        for (int i = 0; i <= randomNumber.Next(0, 3); i++)
        {
            int position = randomNumber.Next(1, Console.WindowWidth - 1);
            int color = randomNumber.Next(0, 6);
            char type = GenerateChar(randomNumber.Next(0, 12));
            int length = randomNumber.Next(1, 4);

            rock = new Rock(position, 0, type, color, length);
            PrintRock(rock);
            rocksQueue.Enqueue(rock);
        }
    }

    private static void RocksMovementManager()
    {
        for (int i = 0; i < rocksQueue.Count; i++)
        {
            rock = rocksQueue.Dequeue();
            Console.SetCursorPosition(rock.PositionX, rock.PositionY);
            for (int j = 0; j < rock.RockLength; j++)
            {
                Console.Write(' ');
            }
            if (rock.PositionY < dwarfPositionY)
            {
                rock.PositionY++;
                PrintRock(rock);
                rocksQueue.Enqueue(rock);
            }
        }
    }

    private static void PrintRock(Rock rock)
    {
        GenerateColor(rock.RockColor);
        Console.SetCursorPosition(rock.PositionX, rock.PositionY);
        for (int i = 0; i < rock.RockLength; i++)
        {
            Console.Write(rock.RockType);
        }
    }

    private static void CollisionCheck()
    {
        foreach (Rock rock in rocksQueue)
        {
            if (rock.PositionY == dwarfPositionY)
            {
                for (int i = 0; i < rock.RockLength; i++)
                {
                    int check = rock.PositionX + i;
                    if (colisionPositions.Contains(check))
                    {
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 6, Console.WindowHeight / 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        lifes--;
                        if (lifes < 0)
                        {
                            Console.WriteLine("Game Over!");
                            Thread.Sleep(2000);
                            return;
                        }
                        Console.WriteLine("You are killed!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        rocksQueue.Clear();
                        SetTable();
                        DrawDworf();
                        return;
                    }

                }
            }
        }
    }

    private static void PrintScoreAndLifes()
    {
        score++;
        counter++;
        if (counter == 300)
        {
            counter = 0;
            lifes++;
        }
        Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 0);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Lifes: {0} Score: {1}", lifes, score);
    }

    static void Main()
    {
        SetTable();
        DrawDworf();

        while (lifes >= 0)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.LeftArrow && dwarfPositionX > 1)
                {
                    ClearDwarf();
                    dwarfPositionX--;
                }
                if (pressedKey.Key == ConsoleKey.RightArrow && dwarfPositionX < Console.WindowWidth - 4)
                {
                    ClearDwarf();
                    dwarfPositionX++;
                }
                DrawDworf();
            }
            RocksGenerator();
            RocksMovementManager();
            PrintScoreAndLifes();
            CollisionCheck();
            Thread.Sleep(150);
        }
    }
}