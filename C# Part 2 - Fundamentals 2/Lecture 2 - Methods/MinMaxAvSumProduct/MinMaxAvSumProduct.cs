//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;

class MinMaxAvSumProduct
{
    static int Minimum(int[] numbers)
    {
        int minimum = numbers[0];

        for (int index = 1; index < numbers.Length; index++)
        {
            if (minimum > numbers[index])
            {
                minimum = numbers[index];
            }
        }

        return minimum;
    }

    static int Maximum(int[] numbers)
    {
        int maximum = numbers[0];

        for (int index = 1; index < numbers.Length; index++)
        {
            if (maximum < numbers[index])
            {
                maximum = numbers[index];
            }
        }

        return maximum;
    }

    static double Average(int[] numbers)
    {
        long sum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            sum = sum + numbers[index];
        }

        double result = sum / (double)numbers.Length;
        return result;
    }

    static long Sum(int[] numbers)
    {
        long sum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            sum = sum + numbers[index];
        }

        return sum;
    }

    static long Product(int[] numbers)
    {
        long product = 1;

        for (int index = 0; index < numbers.Length; index++)
        {
            product = product * numbers[index];
        }

        return product;
    }

    static void Main()
    {
        int[] numbers = { 5, 8, 3, 24, 7 };

        Console.WriteLine("Minimum: {0}", Minimum(numbers));
        Console.WriteLine("Maximum: {0}", Maximum(numbers));
        Console.WriteLine("Average: {0}", Average(numbers));
        Console.WriteLine("Sum: {0}", Sum(numbers));
        Console.WriteLine("Product: {0}\r\n", Product(numbers));
    }
}