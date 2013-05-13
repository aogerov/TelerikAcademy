//Write a program to compare the performance of square root,
//natural logarithm, sinus for float, double and decimal values.

using System;
using System.Diagnostics;

namespace AdvancedMathPerformanceCompare
{
    public class AdvancedMathPerformanceCompare
    {
        private static int loopIterations = 15000000;

        public static void Main()
        {
            Console.WriteLine("Calculations are based on 15'000'000 loop iterations.");

            Console.Write("\r\nSquare root of float         ");
            DisplayExecutionTime(() =>
            {
                for (float i = 0; i < loopIterations; i++)
                {
                    Math.Sqrt(i);
                }
            });

            Console.Write("\r\nNatural logarithm of float   ");
            DisplayExecutionTime(() =>
            {
                for (float i = 0; i < loopIterations; i++)
                {
                    Math.Log(i);
                }
            });

            Console.Write("\r\nSinus of float               ");
            DisplayExecutionTime(() =>
            {
                for (float i = 0; i < loopIterations; i++)
                {
                    Math.Sin(i);
                }
            });

            Console.Write("\r\nSquare root of double        ");
            DisplayExecutionTime(() =>
            {
                for (double i = 0; i < loopIterations; i++)
                {
                    Math.Sqrt(i);
                }
            });

            Console.Write("\r\nNatural logarithm of double  ");
            DisplayExecutionTime(() =>
            {
                for (double i = 0; i < loopIterations; i++)
                {
                    Math.Log(i);
                }
            });

            Console.Write("\r\nSinus of double              ");
            DisplayExecutionTime(() =>
            {
                for (double i = 0; i < loopIterations; i++)
                {
                    Math.Sin(i);
                }
            });

            Console.Write("\r\nSquare root of decimal       ");
            DisplayExecutionTime(() =>
            {
                for (decimal i = 0; i < loopIterations; i++)
                {
                    Math.Sqrt((double)i);
                }
            });

            Console.Write("\r\nNatural logarithm of decimal ");
            DisplayExecutionTime(() =>
            {
                for (decimal i = 0; i < loopIterations; i++)
                {
                    Math.Log((double)i);
                }
            });

            Console.Write("\r\nSinus of decimal             ");
            DisplayExecutionTime(() =>
            {
                for (decimal i = 0; i < loopIterations; i++)
                {
                    Math.Sin((double)i);
                }
            });

            Console.WriteLine();
        }

        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}
