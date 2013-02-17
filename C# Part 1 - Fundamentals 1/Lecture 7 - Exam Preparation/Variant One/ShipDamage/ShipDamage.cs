using System;

class ShipDamage
{
    static int sx1;
    static int sy1;
    static int sx2;
    static int sy2;
    static int h;
    static int cx1;
    static int cy1;
    static int cx2;
    static int cy2;
    static int cx3;
    static int cy3;
    static int damage;

    static void FixCoordinates()
    {
        if (sx1 > sx2)
        {
            sx2 = sx2 + sx1;
            sx1 = sx2 - sx1;
            sx2 = sx2 - sx1;
        }

        if (sy1 > sy2)
        {
            sy2 = sy2 + sy1;
            sy1 = sy2 - sy1;
            sy2 = sy2 - sy1;
        }
    }

    static void SetPositions()
    {
        sy1 = sy1 - h;
        sy2 = sy2 - h;
        cy1 = cy1 - h;
        cy2 = cy2 - h;
        cy3 = cy3 - h;
    }

    static void CatapultAttack()
    {
        cy1 = cy1 * (-1);
        cy2 = cy2 * (-1);
        cy3 = cy3 * (-1);
    }

    private static void AttackDamage(int x, int y)
    {
        if (((x > sx1) && (x < sx2)) && ((y > sy1) && (y < sy2)))
        {
            damage += 100;
        }

        if (((x > sx1) && (x < sx2)) && ((y == sy1) || (y == sy2)))
        {
            damage += 50;
        }

        if (((x == sx1) || (x == sx2)) && ((y > sy1) && (y < sy2)))
        {
            damage += 50;
        }

        if (((x == sx1) && (y == sy1)) || ((x == sx2) && (y == sy2)) || ((x == sx2) && (y == sy1)) || ((x == sx1) && (y == sy2)))
        {
            damage += 25;
        }
    }

    static void Main()
    {
        sx1 = int.Parse(Console.ReadLine());
        sy1 = int.Parse(Console.ReadLine());
        sx2 = int.Parse(Console.ReadLine());
        sy2 = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());
        cx1 = int.Parse(Console.ReadLine());
        cy1 = int.Parse(Console.ReadLine());
        cx2 = int.Parse(Console.ReadLine());
        cy2 = int.Parse(Console.ReadLine());
        cx3 = int.Parse(Console.ReadLine());
        cy3 = int.Parse(Console.ReadLine());
        
        damage = 0;

        FixCoordinates();

        SetPositions();

        CatapultAttack();

        AttackDamage(cx1, cy1);
        AttackDamage(cx2, cy2);
        AttackDamage(cx3, cy3);

        Console.WriteLine("{0}%", damage);
    }
}