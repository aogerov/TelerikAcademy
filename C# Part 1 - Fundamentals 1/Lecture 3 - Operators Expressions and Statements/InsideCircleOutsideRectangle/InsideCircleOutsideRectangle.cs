using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the x-coordinate: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the y-coordinate: ");
        int y = int.Parse(Console.ReadLine());

        bool insideCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 9;
        bool insideRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
        if (insideCircle && !insideRectangle)
        {
            Console.WriteLine("The coordinates ({0}, {1}) are inside the circle and outside the rectangle.", x, y);
        }
        else
        {
            Console.WriteLine("The coordinates ({0}, {1}) are NOT inside the circle and outside the rectangle.", x, y);
        }
    }
}