//Implement a set of extension methods for IEnumerable<T> that implement
//the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;

static class IEnumerableExtensions
{
    public static T Sum<T>(this IEnumerable<T> input)
    {
        dynamic result = input.ElementAt(0);

        for (int i = 1; i < input.Count(); i++)
        {
            result += input.ElementAt(i);
        }

        return result;
    }

    public static T Product<T>(this IEnumerable<T> input)
    {
        dynamic result = input.ElementAt(0);

        for (int i = 1; i < input.Count(); i++)
        {
            result *= input.ElementAt(i);
        }

        return result;
    }

    public static T Min<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic result = input.ElementAt(0);

        for (int i = 1; i < input.Count(); i++)
        {
            if (result > input.ElementAt(i))
            {
                result = input.ElementAt(i);
            }
        }

        return result;
    }

    public static T Max<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic result = input.ElementAt(0);

        for (int i = 1; i < input.Count(); i++)
        {
            if (result < input.ElementAt(i))
            {
                result = input.ElementAt(i);
            }
        }

        return result;
    }

    public static T Average<T>(this IEnumerable<T> input)
    {
        dynamic result = input.ElementAt(0);

        for (int i = 1; i < input.Count(); i++)
        {
            result += input.ElementAt(i);
        }

        return result / input.Count();
    }
}