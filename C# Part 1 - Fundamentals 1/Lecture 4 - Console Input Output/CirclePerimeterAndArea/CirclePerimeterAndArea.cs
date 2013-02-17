using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        string input = Console.ReadLine();
        double radius = double.Parse(input);

        Console.WriteLine("The perimeter of the circle is: {0:F4}", (2 * Math.PI * radius));
        Console.WriteLine("The area of the circle is: {0:F4}", (Math.PI * radius * radius));
    }
}