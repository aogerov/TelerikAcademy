//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;

class Factorials
{
    static int[] factorial;
    static List<int[]> factorials;

    static void PowerFactorial(int power)
    {
        int[] previousNumber = factorials[power - 1];
        int sum = 0;
        int remainder = 0;

        for (int index = 0; index < previousNumber.Length; index++)
        {
            if (index < previousNumber.Length)
            {
                sum = (previousNumber[previousNumber.Length - index - 1] * power) + remainder;
                remainder = 0;

                if (sum > 9)
                {
                    remainder = sum / 10;
                    sum = sum % 10;
                }

                factorial[factorial.Length - index - 1] = sum;
            }

            if (index == previousNumber.Length - 1)
            {
                if (remainder < 10)
                {
                    factorial[factorial.Length - index - 2] = remainder;
                }
                else
                {
                    factorial[factorial.Length - index - 2] = remainder % 10;
                    factorial[factorial.Length - index - 1] = remainder / 10;
                }
            }
        }
    }

    static void DeleteZeroIndexIfNecessary()
    {
        if ((factorial[0] == 0) && (factorial[1] == 0))
        {
            int[] tempArray = new int[factorial.Length - 2];

            for (int index = 0; index < tempArray.Length; index++)
            {
                tempArray[index] = factorial[index + 2];
            }

            factorial = tempArray;
        }
        else if (factorial[0] == 0)
        {
            int[] tempArray = new int[factorial.Length - 1];

            for (int index = 0; index < tempArray.Length; index++)
            {
                tempArray[index] = factorial[index + 1];
            }

            factorial = tempArray;
        }
    }

    static void CalculateFactorial(int index)
    {
        factorial = new int[factorials[index - 1].Length + 2];

        PowerFactorial(index);

        DeleteZeroIndexIfNecessary();
    }

    static void PrintFactorials()
    {
        for (int index = 1; index <= 100; index++)
        {
            Console.Write("{0} -> ", index);
            for (int insideIndex = 0; insideIndex < factorials[index].Length; insideIndex++)
            {
                Console.Write(factorials[index][insideIndex]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        factorials = new List<int[]>();
        factorials.Add(new int[] { 1 });

        for (int index = 1; index <= 100; index++)
        {
            CalculateFactorial(index);
            factorials.Add(factorial);
        }

        PrintFactorials();
    }
}