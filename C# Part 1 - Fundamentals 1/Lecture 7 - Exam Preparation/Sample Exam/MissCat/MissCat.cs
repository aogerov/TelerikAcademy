using System;

class MissCat
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] cats = new int[11];
        int cat;
        int mostVotes = 0;
        int catWinner = 0;

        for (int i = 0; i < N; i++)
        {
            cat = int.Parse(Console.ReadLine());
            cats[cat]++;
        }

        for (int i = 1; i <= 10; i++)
        {
            if (mostVotes < cats[i])
            {
                mostVotes = cats[i];
                catWinner = i;
            }
        }

        if (mostVotes > 0)
        {
            Console.WriteLine(catWinner);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
}