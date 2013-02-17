//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static int GeneratePivot(List<string> list)
    {
        int[] pivots = new int[3];

        Random rnd = new Random();

        for (int i = 0; i < 3; i++)
        {
            pivots[i] = rnd.Next(0, list.Count);
        }

        Array.Sort(pivots);

        return pivots[1];
    }

    static List<string> SortList(List<string> list)
    {
        List<string> leftPart = new List<string>();
        List<string> rightPart = new List<string>();

        int pivot = GeneratePivot(list);

        if (list.Count > 0)
        {
            string pivotStr = list[pivot];

            for (int i = 0; i < list.Count; i++)
            {
                if (i != pivot)
                {
                    if (string.Compare(list[i], list[pivot]) <= 0)
                    {
                        leftPart.Add(list[i]);
                    }
                    else
                    {
                        rightPart.Add(list[i]);
                    }
                }
            }

            leftPart = SortList(leftPart);
            rightPart = SortList(rightPart);

            list.Clear();
            list.AddRange(leftPart);
            list.Add(pivotStr);
            list.AddRange(rightPart);

        }

        return list;
    }

    static void Main()
    {
        string[] strings = { "hello", "proposition", "take", "dog", "bye", "avoid", "zero", "nasty" };

        List<string> list = strings.ToList();

        list = SortList(list);

        Console.WriteLine(String.Join("\r\n", list));
    }
}