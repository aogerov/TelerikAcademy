using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int B = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int bits;
        uint number;

        if (B == 1)
        {
            for (int i = 0; i < N; i++)
            {
                bits = 0;
                number = uint.Parse(Console.ReadLine());
                while (number > 0)
                {
                    if (number % 2 == 1)
                    {
                        bits++;
                    }
                    number /= 2;
                }
                Console.WriteLine(bits);
            }
        }

        if (B == 0)
        {
            for (int i = 0; i < N; i++)
            {
                bits = 0;
                number = uint.Parse(Console.ReadLine());
                while (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        bits++;
                    }
                    number /= 2;
                }
                Console.WriteLine(bits);
            }
        }
    }
}