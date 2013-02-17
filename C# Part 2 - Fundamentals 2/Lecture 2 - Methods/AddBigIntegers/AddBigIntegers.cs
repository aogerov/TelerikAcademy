//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class AddBigIntegers
{
    static int[] biggerNumber;
    static int[] smallerNumber;
    static int[] result;

    static void InputReader()
    {
        Console.WriteLine("Enter first number: ");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Enter second number: ");
        string secondInput = Console.ReadLine();

        if (secondInput.Length > firstInput.Length)
        {
            string switchInput = secondInput;
            secondInput = firstInput;
            firstInput = switchInput;
        }

        biggerNumber = new int[firstInput.Length];
        smallerNumber = new int[secondInput.Length];
        result = new int[biggerNumber.Length + 1];

        for (int index = 0; index < firstInput.Length; index++)
        {
            biggerNumber[index] = int.Parse(firstInput[index].ToString());
        }

        for (int index = 0; index < secondInput.Length; index++)
        {
            smallerNumber[index] = int.Parse(secondInput[index].ToString());
        }
    }

    static void SumNumbers()
    {
        int sum = 0;
        int remainder = 0;

        for (int index = 0; index < result.Length; index++)
        {
            if (index < smallerNumber.Length)
            {
                sum = biggerNumber[biggerNumber.Length - index - 1] + smallerNumber[smallerNumber.Length - index - 1] + remainder;
                remainder = 0;

                if (sum > 9)
                {
                    remainder = 1;
                    sum = sum - 10;
                }

                result[result.Length - index - 1] = sum;
            }
            else if (index < biggerNumber.Length)
            {
                sum = biggerNumber[biggerNumber.Length - index - 1] + remainder;
                remainder = 0;

                if (sum > 9)
                {
                    remainder = 1;
                    sum = sum - 10;
                }

                result[result.Length - index - 1] = sum;
            }
            else
            {
                if (remainder == 1)
                {
                    result[result.Length - index - 1] = remainder;
                }
            }
        }
    }

    static void DeleteZeroIndexIfNecessary()
    {
        if (result[0] == 0)
        {
            int[] tempArray = new int[result.Length - 1];

            for (int index = 0; index < tempArray.Length; index++)
            {
                tempArray[index] = result[index + 1];
            }

            result = tempArray;
        }
    }

    static void PrintResult()
    {
        Console.WriteLine("\r\nResult: ");
        for (int index = 0; index < result.Length; index++)
        {
            Console.Write(result[index]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        InputReader();

        SumNumbers();

        DeleteZeroIndexIfNecessary();

        PrintResult();
    }
}