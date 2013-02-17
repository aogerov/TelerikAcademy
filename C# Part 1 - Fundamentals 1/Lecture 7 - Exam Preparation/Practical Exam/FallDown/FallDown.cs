using System;

class FallDown
{
    static void Main()
    {
        int[] number = new int[8];
        for (int i = 0; i < 8; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        int[] mask = new int[8];
        mask[0] = 1;
        for (int i = 1; i < 8; i++)
        {
            mask[i] = mask[i - 1] << 1;
        }

        for (int i = 0; i < 8; i++)
        {
            for (int row = 7; row > 0; row--)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((number[row - 1] & mask[col]) == mask[col])
                    {
                        if ((number[row] & mask[col]) == 0)
                        {
                            number[row - 1] = number[row - 1] ^ mask[col];
                            number[row] = number[row] | mask[col];
                        }
                    }
                }
            }
        }

        foreach (var item in number)
        {
            Console.WriteLine(item);
        }
    }
}