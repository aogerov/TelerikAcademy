using System;

class FighterAttack
{
    static int plantX1;
    static int plantY1;
    static int plantX2;
    static int plantY2;
    static int fighterX;
    static int fighterY;
    static int distance;
    static int bombCenterX;
    static int bombCenterY;
    static int bombFrontX;
    static int bombFrontY;
    static int bombLeftX;
    static int bombLeftY;
    static int bombRightX;
    static int bombRightY;
    static int damage;


    static void ReadInput()
    {
        plantX1 = int.Parse(Console.ReadLine());
        plantY1 = int.Parse(Console.ReadLine());
        plantX2 = int.Parse(Console.ReadLine());
        plantY2 = int.Parse(Console.ReadLine());
        fighterX = int.Parse(Console.ReadLine());
        fighterY = int.Parse(Console.ReadLine());
        distance = int.Parse(Console.ReadLine());
    }

    static void SetPlantCoordinates()
    {
        if (plantX2 < plantX1)
        {
            plantX2 = plantX2 + plantX1;
            plantX1 = plantX2 - plantX1;
            plantX2 = plantX2 - plantX1;
        }

        if (plantY2 < plantY1)
        {
            plantY2 = plantY2 + plantY1;
            plantY1 = plantY2 - plantY1;
            plantY2 = plantY2 - plantY1;
        }
    }

    static void GenerateBombCoordinates()
    {
        bombCenterX = fighterX + distance;
        bombCenterY = fighterY;
        bombFrontX = bombCenterX + 1;
        bombFrontY = bombCenterY;
        bombLeftX = bombCenterX;
        bombLeftY = bombCenterY + 1;
        bombRightX = bombCenterX;
        bombRightY = bombCenterY - 1;
    }

    static bool CheckPosition(int bombX, int bombY)
    {
        bool output = false;
        if (((bombX >= plantX1) && (bombX <= plantX2)) && ((bombY >= plantY1) && (bombY <= plantY2)))
        {
            output = true;
        }
        return output;
    }

    static void CalculateDamage()
    {
        if (CheckPosition(bombCenterX, bombCenterY))
        {
            damage += 100;
        }

        if (CheckPosition(bombFrontX, bombFrontY))
        {
            damage += 75;
        }

        if (CheckPosition(bombLeftX, bombLeftY))
        {
            damage += 50;
        }

        if (CheckPosition(bombRightX, bombRightY))
        {
            damage += 50;
        }
    }

    static void Main()
    {
        ReadInput();

        SetPlantCoordinates();

        GenerateBombCoordinates();

        CalculateDamage();

        Console.WriteLine("{0}%", damage);
    }
}
