//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5  501

using System;

class AddTwoPolynominals
{
    static void AddPolinaminals(double[] firstPolinomials, double[] secondPolinomials, double[] output)
    {
        for (int index = 0; index < firstPolinomials.Length; index++)
        {
            output[index] = firstPolinomials[index] + secondPolinomials[index];
        }

        if (secondPolinomials.Length > firstPolinomials.Length)
        {
            for (int index = firstPolinomials.Length; index < secondPolinomials.Length; index++)
            {
                output[index] = secondPolinomials[index];
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

        Console.WriteLine("First polinominals:");
        PrintOutput(firstPolinominals);

        Console.WriteLine("Second polinominals:");
        PrintOutput(secondPolinominals);

        if (firstPolinominals.Length > secondPolinominals.Length)
        {
            double[] tempPolinominals = firstPolinominals;
            firstPolinominals = secondPolinominals;
            secondPolinominals = tempPolinominals;
        }

        double[] output = new double[secondPolinominals.Length];

        AddPolinaminals(firstPolinominals, secondPolinominals, output);

        Console.WriteLine("The sum of the two polinominals is:");
        PrintOutput(output);
    }
}