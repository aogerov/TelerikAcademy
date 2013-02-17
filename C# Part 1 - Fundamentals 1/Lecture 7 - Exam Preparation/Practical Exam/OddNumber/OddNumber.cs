using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long[] number = new long[N];
        for (int num = 0; num < N; num++)
        {
            number[num] = long.Parse(Console.ReadLine());
        }

        Dictionary<long, int> dict = new Dictionary<long, int>();
        long oddNumber = 0;
        int count = 0;

        foreach (long num in number)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
            }
            else
            {
                int tempCount;
                dict.TryGetValue(num, out tempCount);
                dict.Remove(num);
                dict.Add(num, ++tempCount);
            }
        }

        foreach (var item in dict)
        {
            if ((count < item.Value) && (item.Value % 2 == 1))
            {
                oddNumber = item.Key;
                count = item.Value;
            }
        }

        if (oddNumber != 0)
        {
            Console.WriteLine(oddNumber);
        }
        else
        {
            Console.WriteLine(number[number.Length - 1]);
        }
    }
}