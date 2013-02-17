using System;

class FirFree
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int dotsCount;
        int asterixCount = 1;

        for (int i = 1; i <= N; i++)
        {
            dotsCount = N - 1 - i;
           
            if (i == N)
            {
                dotsCount = N - 2;
                asterixCount = 1;
            }

            for (int dotsleft = 0; dotsleft < dotsCount; dotsleft++)
            {
                Console.Write(".");
            }
            for (int dots = 0; dots < asterixCount; dots++)
            {
                Console.Write("*");
            }
            for (int dotsright = 0; dotsright < dotsCount; dotsright++)
            {
                Console.Write(".");
            }

            asterixCount = asterixCount + 2;
            Console.WriteLine();
        }
    }
}