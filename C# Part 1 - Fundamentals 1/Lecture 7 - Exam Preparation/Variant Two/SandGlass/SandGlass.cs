using System;

class SandGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int dotsCount = 0;
        int asterixCount = 0;

        for (int i = 1; i <= N; i++)
        {
            if (i <= ((N /2) + 1))
            {
                dotsCount = i - 1;
                asterixCount = N - (i * 2 - 1) + 1;
            }
            else
            {
                dotsCount = dotsCount - 1;
                asterixCount = asterixCount + 2;
            }
           
            for (int leftDots = 0; leftDots < dotsCount; leftDots++)
            {
                Console.Write(".");
            }
            for (int asterix = 0; asterix < asterixCount; asterix++)
            {
                Console.Write("*");
            }
            for (int rightDots = 0; rightDots < dotsCount; rightDots++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}