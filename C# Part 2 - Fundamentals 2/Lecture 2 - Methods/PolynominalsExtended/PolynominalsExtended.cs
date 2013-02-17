//Extend the program to support also subtraction and multiplication of polynomials.

using System;

class AddTwoPolynominals
{
    static void PolinaminalsSum(double[] firstPolinomials, double[] secondPolinomials, double[] sum)
    {
        for (int index = 0; index < firstPolinomials.Length; index++)
        {
            sum[index] = firstPolinomials[index] + secondPolinomials[index];
        }

        if (secondPolinomials.Length > firstPolinomials.Length)
        {
            for (int index = firstPolinomials.Length; index < secondPolinomials.Length; index++)
            {
                sum[index] = secondPolinomials[index];
            }
        }
    }

    static void PolinaminalsSubtraction(double[] firstPolinomials, double[] secondPolinomials, double[] subtractions)
    {
        for (int index = 0; index < firstPolinomials.Length; index++)
        {
            subtractions[index] = firstPolinomials[index] - secondPolinomials[index];
        }

        if (secondPolinomials.Length > firstPolinomials.Length)
        {
            for (int index = firstPolinomials.Length; index < secondPolinomials.Length; index++)
            {
                subtractions[index] = secondPolinomials[index];
            }
        }
    }

    static void PolinaminalsMultiplication(double[] firstPolinomials, double[] secondPolinomials, double[] multiplications)
    {
        for (int index = 0; index < multiplications.Length; index++)
        {
            multiplications[index] = 0;
        }

        for (int i = 0; i < secondPolinomials.Length; i++)
        {
            for (int j = 0; j < firstPolinomials.Length; j++)
            {
                multiplications[j + i] = multiplications[j + i] + firstPolinomials[j] * secondPolinomials[i];
            }
        }
    }

    static void PrintOutput(double[] array)
    {
        for (int index = array.Length - 1; index >= 0; index--)
        {
            if ((array[index] != 0) && (index > 0))
            {
                if (array[index - 1] >= 0)
                {
                    Console.Write("{1}*x^{0} + ", index, array[index]);
                }
                else
                {
                    Console.Write("{1}*x^{0} ", index, array[index]);
                }
            }
            else if (index == 0)
            {
                Console.Write("{0}", array[index]);
            }
        }

        Console.WriteLine("\r\n");
    }

    static void Main()
    {
        double[] firstPolinominals = { 6, -4, 23, 8 };
        double[] secondPolinominals = { -3, 12, 5 };

        Console.WriteLine("First polinominal:");
        PrintOutput(firstPolinominals);

        Console.WriteLine("Second polinominal:");
        PrintOutput(secondPolinominals);

        if (firstPolinominals.Length > secondPolinominals.Length)
        {
            double[] tempPolinominals = firstPolinominals;
            firstPolinominals = secondPolinominals;
            secondPolinominals = tempPolinominals;
        }

        double[] sum = new double[secondPolinominals.Length];
        double[] subtractions = new double[secondPolinominals.Length];
        double[] multiplications = new double[firstPolinominals.Length + secondPolinominals.Length];

        PolinaminalsSum(firstPolinominals, secondPolinominals, sum);

        PolinaminalsSubtraction(firstPolinominals, secondPolinominals, subtractions);

        PolinaminalsMultiplication(firstPolinominals, secondPolinominals, multiplications);

        Console.WriteLine("The sum of the two polinominals is:");
        PrintOutput(sum);

        Console.WriteLine("The subtraction of the two polinominals is:");
        PrintOutput(subtractions);

        Console.WriteLine("The multiplication of the two polinominals is:");
        PrintOutput(multiplications);
    }
}