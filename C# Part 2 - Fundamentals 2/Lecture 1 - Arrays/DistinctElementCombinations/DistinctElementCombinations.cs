//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class DistinctElementCombinations
{
    static int N;
    static int K;
    static int[] array;

    static void ReadInput()
    {
        Console.Write("N: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        K = int.Parse(Console.ReadLine());
    }

    static void InitializeArray()
    {
        array = new int[K];

        for (int i = 0; i < K; i++)
        {
            array[i] = 1;
        }
    }

    static bool CheckForRepetition()
    {
        bool repetitionFound = false;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    repetitionFound = true;

                    return repetitionFound;
                }
            }
        }

        return repetitionFound;
    }

    static void GenerateVariations()
    {
        int position = array.Length - 1;
        int previousPosition = position - 1;

        for (int i = 1; i <= N; i++)
        {
            array[position] = i;

            if (!CheckForRepetition())
            {
                Console.WriteLine(String.Join(", ", array));
            }

            if (i == N)
            {
                if (array[previousPosition] < N)
                {
                    array[previousPosition]++;
                }
                else
                {
                    previousPosition--;

                    if (previousPosition < 0)
                    {
                        return;
                    }

                    array[previousPosition]++;
                }

                i = 0;
            }
        }
    }

    static void Main()
    {
        ReadInput();

        InitializeArray();

        GenerateVariations();
    }
}