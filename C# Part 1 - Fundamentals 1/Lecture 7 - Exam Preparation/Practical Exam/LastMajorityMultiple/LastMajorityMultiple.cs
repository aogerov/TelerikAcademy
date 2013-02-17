using System;

class LastMajorityMultiple
{
    static void Main()
    {
        int[] number = new int[5];
        for (int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(number);

        int counter = 0;

        for (int i = number[0]; i < number[2] * number[3] * number [4]; i++)
        {
            if (i % number[0] == 0)
            {
                counter++;
            }
            if (i % number[1] == 0)
            {
                counter++;
            }
            if (i % number[2] == 0)
            {
                counter++;
            }
            if (i % number[3] == 0)
            {
                counter++;
            }
            if (i % number[4] == 0)
            {
                counter++;
            }

            if (counter >= 3)
            {
                Console.WriteLine(i);
                break;
            }
            else
            {
                counter = 0;
            }
        }
    }
}