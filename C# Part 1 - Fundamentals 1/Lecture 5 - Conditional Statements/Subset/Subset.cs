using System;
using System.Text;

class Subset
{
    static int first;
    static int second;
    static int third;
    static int fourth;
    static int fifth;
    static bool foundSubset;
    static string printResult;

    private static void CheckForSubset()
    {
        if (first == 0)
        {
            PrintSubsetOfOne();
        }
        if (second == 0)
        {
            PrintSubsetOfOne();
        }
        if (third == 0)
        {
            PrintSubsetOfOne();
        }
        if (fourth == 0)
        {
            PrintSubsetOfOne();
        }
        if (fifth == 0)
        {
            PrintSubsetOfOne();
        }
        if (first + second == 0)
        {
            PrintSubsetOfTwo(first, second);
        }
        if (first + third == 0)
        {
            PrintSubsetOfTwo(first, third);
        }
        if (first + fourth == 0)
        {
            PrintSubsetOfTwo(first, fourth);
        }
        if (first + fifth == 0)
        {
            PrintSubsetOfTwo(first, fifth);
        }
        if (second + third == 0)
        {
            PrintSubsetOfTwo(second, third);
        }
        if (second + fourth == 0)
        {
            PrintSubsetOfTwo(second, fourth);
        }
        if (second + fifth == 0)
        {
            PrintSubsetOfTwo(second, fifth);
        }
        if (third + fourth == 0)
        {
            PrintSubsetOfTwo(third, fourth);
        }
        if (third + fifth == 0)
        {
            PrintSubsetOfTwo(third, fifth);
        }
        if (fourth + fifth == 0)
        {
            PrintSubsetOfTwo(fourth, fifth);
        }
        if (first + second + third == 0)
        {
            PrintSubsetOfThree(first, second, third);
        }
        if (first + second + fourth == 0)
        {
            PrintSubsetOfThree(first, second, fourth);
        }
        if (first + second + fifth == 0)
        {
            PrintSubsetOfThree(first, second, fifth);
        }
        if (first + third + fourth == 0)
        {
            PrintSubsetOfThree(first, third, fourth);
        }
        if (first + third + fifth == 0)
        {
            PrintSubsetOfThree(first, third, fifth);
        }
        if (first + fourth + fifth == 0)
        {
            PrintSubsetOfThree(first, fourth, fifth);
        }
        if (second + third + fourth == 0)
        {
            PrintSubsetOfThree(second, third, fourth);
        }
        if (second + third + fifth == 0)
        {
            PrintSubsetOfThree(second, third, fifth);
        }
        if (second + fourth + fifth == 0)
        {
            PrintSubsetOfThree(second, fourth, fifth);
        }
        if (third + fourth + fifth == 0)
        {
            PrintSubsetOfThree(third, fourth, fifth);
        }
        if (first + second + third + fourth == 0)
        {
            PrintSubsetOfFour(first, second, third, fourth);
        }
        if (first + second + third + fifth == 0)
        {
            PrintSubsetOfFour(first, second, third, fifth);
        }
        if (first + second + fourth + fifth == 0)
        {
            PrintSubsetOfFour(first, second, fourth, fifth);
        }
        if (first + third + fourth + fifth == 0)
        {
            PrintSubsetOfFour(first, third, fourth, fifth);
        }
        if (first + third + fourth + fifth == 0)
        {
            PrintSubsetOfFour(second, third, fourth, fifth);
        }
        if (first + second + third + fourth + fifth == 0)
        {
            PrintSubsetOfFive(first, second, third, fourth, fifth);
        }
    }

    private static void PrintSubsetOfOne()
    {
        Console.WriteLine("0 = 0");
        foundSubset = true;
    }

    private static void PrintSubsetOfTwo(int first, int second)
    {
        if (first > 0)
        {
            printResult += first;
        }
        else
        {
            printResult += "(-" + (first * -1) + ")";
        }
        if (second > 0)
        {
            printResult += " + " + second + " = 0";
        }
        else
        {
            printResult += " - " + (second * -1) + " = 0";
        }
        Console.WriteLine(printResult);
        printResult = "";
        foundSubset = true;
    }

    private static void PrintSubsetOfThree(int first, int second, int third)
    {
        if (first > 0)
        {
            printResult += first;
        }
        else
        {
            printResult += "(-" + (first * -1) + ")";
        }
        if (second > 0)
        {
            printResult += " + " + second;
        }
        else
        {
            printResult += " - " + (second * -1);
        }
        if (third > 0)
        {
            printResult += " + " + third + " = 0";
        }
        else
        {
            printResult += " - " + (third * -1) + " = 0";
        }
        Console.WriteLine(printResult);
        printResult = "";
        foundSubset = true;
    }

    private static void PrintSubsetOfFour(int first, int second, int third, int fourth)
    {
        if (first > 0)
        {
            printResult += first;
        }
        else
        {
            printResult += "(-" + (first * -1) + ")";
        }
        if (second > 0)
        {
            printResult += " + " + second;
        }
        else
        {
            printResult += " - " + (second * -1);
        }
        if (third > 0)
        {
            printResult += " + " + third;
        }
        else
        {
            printResult += " - " + (third * -1);
        }
        if (fourth > 0)
        {
            printResult += " + " + fourth + " = 0";
        }
        else
        {
            printResult += " - " + (fourth * -1) + " = 0";
        }
        Console.WriteLine(printResult);
        printResult = "";
        foundSubset = true;
    }

    private static void PrintSubsetOfFive(int first, int second, int third, int fourth, int fifth)
    {
        if (first > 0)
        {
            printResult += first;
        }
        else
        {
            printResult += "(-" + (first * -1) + ")";
        }
        if (second > 0)
        {
            printResult += " + " + second;
        }
        else
        {
            printResult += " - " + (second * -1);
        }
        if (third > 0)
        {
            printResult += " + " + third;
        }
        else
        {
            printResult += " - " + (third * -1);
        }
        if (fourth > 0)
        {
            printResult += " + " + fourth;
        }
        else
        {
            printResult += " - " + (fourth * -1);
        }
        if (fifth > 0)
        {
            printResult += " + " + fifth + " = 0";
        }
        else
        {
            printResult += " - " + (fifth * -1) + " = 0";
        }
        Console.WriteLine(printResult);
        printResult = "";
        foundSubset = true;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        third = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        fourth = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        fifth = int.Parse(Console.ReadLine());

        CheckForSubset();

        if (!foundSubset)
        {
            Console.WriteLine("There is no subset of these numbers.");
        }
    }
}