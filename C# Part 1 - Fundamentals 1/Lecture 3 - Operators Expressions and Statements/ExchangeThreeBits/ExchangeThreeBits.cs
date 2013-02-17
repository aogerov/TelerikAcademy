using System;

class ExchangeThreeBits
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 3; i < 6; i++)
        {
            int firstMask = 1;
            firstMask <<= i;
            firstMask &= number;
            firstMask >>= i;
            int secondMask = 1;
            secondMask <<= i + 21;
            secondMask &= number;
            secondMask >>= i + 21;
            if (firstMask != secondMask)
            {
                if (firstMask == 1)
                {
                    firstMask <<= i + 21;
                    number |= firstMask;
                    secondMask = 1;
                    secondMask <<= i;
                    secondMask = ~secondMask;
                    number &= secondMask;
                }
                else
                {
                    firstMask = 1; 
                    firstMask <<= i + 21;
                    firstMask = ~firstMask;
                    number &= firstMask;
                    secondMask <<= i;
                    number |= secondMask;
                }
            }
        }

        Console.WriteLine("Modified number: " + number);
    }
}