using System;
using System.Collections.Generic;

class SubsetSums
{
    static void Main()
    {
        long S = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long[] number = new long[N];
        for (int i = 0; i < N; i++)
        {
            number[i] = long.Parse(Console.ReadLine());
        }
        
        int counter = 0;
        long tempResult;

        List<long[]> subsets = new List<long[]>();

        for (int i = 0; i < number.Length; i++)
        {
            int subsetCount = subsets.Count;
            subsets.Add(new long[] { number[i] });

            for (int j = 0; j < subsetCount; j++)
            {
                long[] newSubset = new long[subsets[j].Length + 1];
                subsets[j].CopyTo(newSubset, 0);
                newSubset[newSubset.Length - 1] = number[i];
                subsets.Add(newSubset);
            }
        }

        foreach (var subset in subsets)
        {
            tempResult = 0;
            foreach (var num in subset)
            {
                tempResult += num;
            }
            if (tempResult == S)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}