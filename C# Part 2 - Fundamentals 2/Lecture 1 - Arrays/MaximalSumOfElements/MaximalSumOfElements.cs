//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalSumOfElements
{
    static void Main()
    {
        int maxSum = 0;

        //read N and K
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());

        //check if K is bigger than N
        if (K > N)
        {
            Console.WriteLine("Wrong input, K is bigger than N!");
            return;
        }

        //set numbers to array
        for (int index = 0; index < N; index++)
        {
            Console.Write("Enter number {0} of {1}: ", index + 1, N);
            numbers[index] = int.Parse(Console.ReadLine());
        }

        //sorting array
        Array.Sort(numbers);

        //calculating max sum
        for (int index = 0; index < K; index++)
        {
            maxSum = maxSum + numbers[numbers.Length - index - 1];
        }

        //print result
        Console.WriteLine("Result: {0}", maxSum);
    }
}