using System;

class TrapecoidsArea
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid's side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is " + (((sideA + sideB) / 2) * height));
    }
}