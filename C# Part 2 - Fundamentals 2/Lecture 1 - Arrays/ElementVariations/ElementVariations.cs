//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class ElementVariations
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

    static void GenerateVariations()
    {
        int position = array.Length - 1;
        int previousPosition = position - 1;

        for (int i = 1; i <= N; i++)
        {
            array[position] = i;

            Console.WriteLine(String.Join(", ", array));

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