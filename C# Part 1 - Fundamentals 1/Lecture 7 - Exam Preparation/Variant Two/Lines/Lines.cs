using System;

class Lines
{
    static void Main()
    {
        int[] numbers = new int[8];
        int horizontalLength = 0;
        int horizontalCounter = 0;
        int verticalLength = 0;
        int verticalCounter = 0;
        int maxLength = 0;
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            while (number > 0)
            {
                int insideLength = 0;
                while ((number % 2) == 1)
                {
                    insideLength++;
                    number = number / 2;
                }
                if (horizontalLength == insideLength)
                {
                    horizontalCounter++;
                }
                if (horizontalLength < insideLength)
                {
                    horizontalLength = insideLength;
                    horizontalCounter = 1;
                }
                number = number / 2;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            int mask = 1;
            mask = mask << i;

            for (int row = 0; row < numbers.Length; row++)
            {
                int insideLength = 0;
                while ((numbers[row] & mask) == mask)
                {
                    insideLength++;

                    if (verticalLength == insideLength)
                    {
                        verticalCounter++;
                    }
                    if (verticalLength < insideLength)
                    {
                        verticalLength = insideLength;
                        verticalCounter = 1;
                    }

                    if (row < numbers.Length - 1)
                    {
                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
                insideLength = 0;
            }
        }

        if ((horizontalLength == 1) && (verticalLength == 1))
        {
            maxLength = horizontalLength;
            counter += horizontalCounter;
            Console.WriteLine(maxLength);
            Console.WriteLine(counter);
        }
        else
        {
            if (horizontalLength > verticalLength)
            {
                maxLength = horizontalLength;
                counter = horizontalCounter;
            }
            if (verticalLength > horizontalLength)
            {
                maxLength = verticalLength;
                counter = verticalCounter;
            }
            if (horizontalLength == verticalLength)
            {
                maxLength = horizontalLength;
                counter += horizontalCounter;
                counter += verticalCounter;
            }
            Console.WriteLine(maxLength);
            Console.WriteLine(counter);
        }
    }
}