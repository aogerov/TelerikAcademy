using System;

class Pillars
{
    static int[] number = new int[8];
    static int leftSideCounter;
    static int rightSideCounter;
    static bool foundSolution;

    static int BytesCounter(int left, int right)
    {
        int count = 0;
        int mask = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int col = left; col > right; col--)
            {
                mask = 1;
                mask = mask << col;
                if ((mask & number[i]) != 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void Main()
    {
        for (int i = 0; i < 8; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        for (int col = 7; col >= 0; col--)
        {
            leftSideCounter = BytesCounter(7, col);
            rightSideCounter = BytesCounter(col - 1, -1);
            if (leftSideCounter == rightSideCounter)
            {
                Console.WriteLine(col);
                Console.WriteLine(rightSideCounter);
                foundSolution = true;
                break;
            }
        }

        if (!foundSolution)
        {
            Console.WriteLine("No");
        }
    }
}