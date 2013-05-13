//Write a program to compare the performance of add, subtract, increment,
//multiply, divide for int, long, float, double and decimal values.

using System;
using System.Diagnostics;

public class BasicMathPerformanceCompare
{
    private static int intNum = 3;
    private static long longNum = 3;
    private static float floatNum = 3f;
    private static double doubleNum = 3;
    private static decimal decimalNum = 3;
    private static int outsideLoopCounter = 10000000;
    private static int internaLoopCounter = 25;

    public static void Main()
    {
        Console.WriteLine("Calculations are based on 250'000'000 loop iterations.");

        Console.Write("\r\nAdd int           ");
        DisplayExecutionTime(() =>
            {
                int result = 3;

                for (int i = 0; i < outsideLoopCounter; i++)
                {
                    for (int k = 0; k < internaLoopCounter; k++)
                    {
                        result += intNum;
                    }

                    result = 3;
                }
            });

        Console.Write("\r\nSubstract int     ");
        DisplayExecutionTime(() =>
        {
            int result = 1500000003;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result -= intNum;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nIncrement int     ");
        DisplayExecutionTime(() =>
        {
            int result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result++;
                }

                result = 3;
            }
        });

        Console.Write("\r\nMultiply int      ");
        DisplayExecutionTime(() =>
        {
            int result = 3;
            int multiplier = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result *= multiplier;
                }

                result = 3;
            }
        });

        Console.Write("\r\nDivide int        ");
        DisplayExecutionTime(() =>
        {
            int result = 1500000003;
            int divisor = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result /= divisor;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nAdd long          ");
        DisplayExecutionTime(() =>
        {
            long result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result += longNum;
                }

                result = 3;
            }
        });

        Console.Write("\r\nSubstract long    ");
        DisplayExecutionTime(() =>
        {
            long result = 1500000003;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result -= longNum;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nIncrement long    ");
        DisplayExecutionTime(() =>
        {
            long result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result++;
                }

                result = 3;
            }
        });

        Console.Write("\r\nMultiply long     ");
        DisplayExecutionTime(() =>
        {
            long result = 3;
            long multiplier = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result *= multiplier;
                }

                result = 3;
            }
        });

        Console.Write("\r\nDivide long       ");
        DisplayExecutionTime(() =>
        {
            long result = 1500000003;
            long divisor = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result /= divisor;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nAdd float         ");
        DisplayExecutionTime(() =>
        {
            float result = 3f;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result += floatNum;
                }

                result = 3f;
            }
        });

        Console.Write("\r\nSubstract float   ");
        DisplayExecutionTime(() =>
        {
            float result = 1500000003f;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result -= floatNum;
                }

                result = 1500000003f;
            }
        });

        Console.Write("\r\nIncrement float   ");
        DisplayExecutionTime(() =>
        {
            float result = 3f;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result++;
                }

                result = 3f;
            }
        });

        Console.Write("\r\nMultiply float    ");
        DisplayExecutionTime(() =>
        {
            float result = 3f;
            float multiplier = 2f;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result *= multiplier;
                }

                result = 3f;
            }
        });

        Console.Write("\r\nDivide float      ");
        DisplayExecutionTime(() =>
        {
            float result = 1500000003f;
            float divisor = 2f;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result /= divisor;
                }

                result = 1500000003f;
            }
        });

        Console.Write("\r\nAdd double        ");
        DisplayExecutionTime(() =>
        {
            double result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result += doubleNum;
                }

                result = 3;
            }
        });

        Console.Write("\r\nSubstract double  ");
        DisplayExecutionTime(() =>
        {
            double result = 1500000003;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result -= doubleNum;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nIncrement double  ");
        DisplayExecutionTime(() =>
        {
            double result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result++;
                }

                result = 3;
            }
        });

        Console.Write("\r\nMultiply double   ");
        DisplayExecutionTime(() =>
        {
            double result = 3;
            double multiplier = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result *= multiplier;
                }

                result = 3;
            }
        });

        Console.Write("\r\nDivide double     ");
        DisplayExecutionTime(() =>
        {
            double result = 1500000003;
            double divisor = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result /= divisor;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nAdd decimal       ");
        DisplayExecutionTime(() =>
        {
            decimal result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result += decimalNum;
                }

                result = 3;
            }
        });

        Console.Write("\r\nSubstract decimal ");
        DisplayExecutionTime(() =>
        {
            decimal result = 1500000003;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result -= decimalNum;
                }

                result = 1500000003;
            }
        });

        Console.Write("\r\nIncrement decimal ");
        DisplayExecutionTime(() =>
        {
            decimal result = 3;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result++;
                }

                result = 3;
            }
        });

        Console.Write("\r\nMultiply decimal  ");
        DisplayExecutionTime(() =>
        {
            decimal result = 3;
            decimal multiplier = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result *= multiplier;
                }

                result = 3;
            }
        });

        Console.Write("\r\nDivide decimal    ");
        DisplayExecutionTime(() =>
        {
            decimal result = 1500000003;
            decimal divisor = 2;

            for (int i = 0; i < outsideLoopCounter; i++)
            {
                for (int k = 0; k < internaLoopCounter; k++)
                {
                    result /= divisor;
                }

                result = 1500000003;
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