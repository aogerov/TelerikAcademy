using System;

class WeAllLoveBits
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int P = 0;
        int inputP = 0;
        int tildaP = 0;
        int reversedP = 0;
        int mask;
        int result;

        for (int i = 0; i < N; i++)
        {
            P = int.Parse(Console.ReadLine());
            inputP = P;
            tildaP = P;
            reversedP = 0;

            for (int bit = 30; bit >= 0; bit--)
            {
                mask = 1;
                mask = mask << bit;
                mask = mask & P;
                mask = mask >> bit;
                if (mask == 1)
                {
                    for (int tildaBits = bit; tildaBits >= 0; tildaBits--)
                    {
                        mask = 1;
                        mask = mask << tildaBits;
                        mask = mask & tildaP;
                        mask = mask >> tildaBits;
                        if (mask == 1)
                        {
                            mask = mask << tildaBits;
                            tildaP = mask ^ tildaP;
                        }
                        else
                        {
                            mask = 1;
                            mask = mask << tildaBits;
                            tildaP = mask | tildaP;
                        }
                    }

                    for (int reversedBits = bit; reversedBits >= 0; reversedBits--)
                    {
                        mask = 1;
                        mask = mask & P;
                        reversedP <<= 1;
                        reversedP = mask | reversedP;
                        P >>= 1;
                    }
                    break;
                }
            }

            result = ((inputP ^ tildaP) & reversedP);
            Console.WriteLine(result);
        }
    }
}