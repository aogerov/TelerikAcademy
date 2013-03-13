//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface
//of the figure (height*width for rectangle and height*width/2 for triangle).
//Define class Circle and suitable constructor so that at initialization height must be kept equal to width
//and implement the CalculateSurface() method. Write a program that tests the behavior
//of the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

using System;

class ShapesProgram
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Triangle(4, 3),
            new Rectangle(3, 8),
            new Circle(5.5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine("{0} area is: {1}", shape.GetType(), shape.CalculateSurface());
        }
    }
}