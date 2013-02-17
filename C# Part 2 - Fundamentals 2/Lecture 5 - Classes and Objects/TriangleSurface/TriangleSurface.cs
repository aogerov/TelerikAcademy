//Write methods that calculate the surface of a triangle by given:
//- Side and an altitude to it;
//- Three sides;
//- Two sides and an angle between them.
//Use System.Math.

using System;

class TriangleSurface
{
    static int choice;
    static double aSide;
    static double bSide;
    static double cSide;
    static double altitude;
    static int angle;
    static double result;

    static void InputReader()
    {
        string input;

        Console.WriteLine("Make a choice for the caculation:");
        Console.WriteLine("1. for side and an altitude to it.");
        Console.WriteLine("2. for three sides.");
        Console.WriteLine("3. for two sides and an angle between them.");
        input = Console.ReadLine();

        if ((int.TryParse(input, out choice)) && (choice >= 1) && (choice <= 3))
        {
            choice = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input!");
            InputReader();
            return;
        }

        if (choice == 1)
        {
            Console.Write("Enter a side: ");
            aSide = int.Parse(Console.ReadLine());
            Console.Write("Enter an altitude: ");
            altitude = int.Parse(Console.ReadLine());
        }
        else if (choice == 2)
        {
            Console.Write("Enter first side: ");
            aSide = int.Parse(Console.ReadLine());
            Console.Write("Enter second side: ");
            bSide = int.Parse(Console.ReadLine());
            Console.Write("Enter third side: ");
            cSide = int.Parse(Console.ReadLine());
        }
        else if (choice == 3)
        {
            Console.Write("Enter first side: ");
            aSide = int.Parse(Console.ReadLine());
            Console.Write("Enter second side: ");
            bSide = int.Parse(Console.ReadLine());
            Console.Write("Enter an angle: ");
            angle = int.Parse(Console.ReadLine());
        }
    }

    static void SideAltitude()
    {
        result = aSide * altitude / 2;
    }

    static void ThreeSides()
    {
        double p = (aSide + bSide + cSide) / 2;

        result = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
    }

    static void TwoSidesAndAngle()
    {
        result = (aSide * bSide * Math.Sin(angle * Math.PI / 180)) / 2;
    }

    static void CalculateSurface()
    {
        if (choice == 1)
        {
            SideAltitude();
        }
        else if (choice == 2)
        {
            ThreeSides();
        }
        else if (choice == 3)
        {
            TwoSidesAndAngle();
        }
    }

    static void PrintResult()
    {
        Console.WriteLine("Result: {0}", result);
    }

    static void Main()
    {
        InputReader();

        CalculateSurface();

        PrintResult();
    }
}