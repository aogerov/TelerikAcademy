using System;

class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of rectangle with width {0} and height {1} is: {2}", width, height, (width * height));
    }
}