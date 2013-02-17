using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        if ((X == 0) && (Y == 0))
        {
            Console.WriteLine(0);
            return;
        }

        if ((X == 0) && (Y != 0))
        {
            Console.WriteLine(5);
            return;
        }

        if ((X != 0) && (Y == 0))
        {
            Console.WriteLine(6);
            return;
        }

        if ((X > 0) && (Y > 0))
        {
            Console.WriteLine(1);
        }
        if ((X < 0) && (Y > 0))
        {
            Console.WriteLine(2);
        }
        if ((X < 0) && (Y < 0))
        {
            Console.WriteLine(3);
        }
        if ((X > 0) && (Y < 0))
        {
            Console.WriteLine(4);
        }
    }
}