using System;

class ExchangeSeveralBits
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter lower bit for change: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter higher bit for change: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many bits in a row should be exchanged: ");
        int k = int.Parse(Console.ReadLine());

        if ((p + k < 32) && (q + k < 32))
        {
            int count = p + k;
            while (p <= count)
            {
                int firstMask = 1;
                firstMask <<= p;
                firstMask &= number;
                firstMask >>= p;
                int secondMask = 1;
                secondMask <<= q;
                secondMask &= number;
                secondMask >>= q;
                if (firstMask != secondMask)
                {
                    if (firstMask == 1)
                    {
                        firstMask <<= q;
                        number |= firstMask;
                        secondMask = 1;
                        secondMask <<= p;
                        secondMask = ~secondMask;
                        number &= secondMask;
                    }
                    else
                    {
                        firstMask = 1;
                        firstMask <<= q;
                        firstMask = ~firstMask;
                        number &= firstMask;
                        secondMask <<= p;
                        number |= secondMask;
                    }
                }
                p++;
                q++;
            }
            Console.WriteLine("Modified number: " + number);
        }
        else
        {
            Console.WriteLine("ERROR! Integer can't contain more than 32 bits!");
        }
    }
}
