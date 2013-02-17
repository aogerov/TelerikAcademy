using System;

class RealRoots
{
    static void Main()
    {
        string inputA;
        string inputB;
        string inputC;
        int a;
        int b;
        int c;
        int discriminant;
        double realRootOne;
        double realRootTwo;

        Console.Write("Enter coefficient a: ");
        inputA = Console.ReadLine();
        Console.Write("Enter coefficient b: ");
        inputB = Console.ReadLine();
        Console.Write("Enter coefficient c: ");
        inputC = Console.ReadLine();

        if (int.TryParse(inputA, out a) && int.TryParse(inputB, out b) && int.TryParse(inputC, out c))
        {
            if (a == 0)
            {
                Console.WriteLine("Error! Coefficient a can't be 0. Calculation failure!");
            }
            else
            {
                a = int.Parse(inputA);
                b = int.Parse(inputB);
                c = int.Parse(inputC);

                discriminant = b * b - 4 * a * c;

                if (discriminant < 0)
                {
                    Console.WriteLine("The discriminant is less than 0! There are no real roots!");
                }
                else if (discriminant == 0)
                {
                    Console.Write("The discriminant is 0. There is 1 real root -> ");
                    realRootOne = -(b / (2.0 * a));
                    Console.WriteLine(realRootOne);
                }
                else if (discriminant > 0)
                {
                    Console.WriteLine("The discriminant is more than 0! There are 2 real roots!");
                    realRootOne = ((-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a));
                    realRootTwo = ((-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a));
                    Console.WriteLine(realRootOne);
                    Console.WriteLine(realRootTwo);
                }
            }
        }
    }
}