using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the x-coordinate: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the y-coordinate: ");
        int y = int.Parse(Console.ReadLine());

        bool insideCircle = (x * x) + (y * y) <= 25;
        if (insideCircle)
        {
            Console.WriteLine("The coordinates are inside the circle.");
        }
        else
        {
            Console.WriteLine("The coordinates are OUTSIDE the circle.");
        }
    }
}