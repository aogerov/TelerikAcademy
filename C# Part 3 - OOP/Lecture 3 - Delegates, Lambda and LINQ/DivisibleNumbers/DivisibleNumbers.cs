//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

class DivisibleNumbers
{
    public static int[] FindWithConditional(int[] numbers)
    {
        List<int> results = new List<int>();

        foreach (var number in numbers)
        {
            if (number % 7 == 0 || number % 3 == 0)
            {
                results.Add(number);
            }
        }

        return results.ToArray();
    }

    public static IEnumerable<int> FindWithLambda(int[] numbers)
    {
        return numbers.Where(number => number % 7 == 0 || number % 3 == 0);
    }

    public static IEnumerable<int> FindWithLinq(int[] numbers)
    {
        return (from number in numbers
                where number % 7 == 0 || number % 3 == 0
                select number);
    }
}