using System;

class TestProgram
{
    static void Main()
    {
        Matrix<int> firstMatrix = new Matrix<int>(2, 2);

        firstMatrix[0, 0] = 5;
        firstMatrix[0, 1] = 10;
        firstMatrix[1, 0] = 15;
        firstMatrix[1, 1] = 20;

        Console.WriteLine("First matrix:");
        Console.WriteLine(firstMatrix);
        Console.WriteLine("--------------");

        Matrix<int> secondMatrix = new Matrix<int>(new int[,] {
            {1, 2},
            {3, 4}
        });

        Console.WriteLine("Second matrix:");
        Console.WriteLine(secondMatrix);
        Console.WriteLine("--------------");

        Console.WriteLine("Sum matrices:");
        Console.WriteLine(firstMatrix + secondMatrix);

        Console.WriteLine("Substract matrices:");
        Console.WriteLine(firstMatrix - secondMatrix);
        Console.WriteLine("--------------");
        Console.WriteLine("--------------");

        Console.WriteLine("Matrix multiplication:");
        Console.WriteLine(firstMatrix * secondMatrix);
        Console.WriteLine("--------------");

        firstMatrix[1, 1] = 0;

        Console.WriteLine("Check for zero positions:");
        if (firstMatrix)
        {
            Console.WriteLine("No zero positions found.");
        }
        else
        {
            Console.WriteLine("Found zero position(s).");
        }
        Console.WriteLine("--------------");
    }
}