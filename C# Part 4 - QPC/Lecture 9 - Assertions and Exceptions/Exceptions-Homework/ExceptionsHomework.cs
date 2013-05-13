using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (startIndex < 0 || count < 0)
        {
            throw new ArgumentOutOfRangeException("Parameters can't be nagative.");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("Too big length.");
        }

        if (arr == null)
        {
            throw new ArgumentNullException("Array has no elements");
        }

        List<T> result = new List<T>();

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null || str == string.Empty)
        {
            throw new ArgumentNullException("Input string don't exists or is empty.");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("Count can't be negative");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count is bigger than string length.");
        }

        StringBuilder result = new StringBuilder();

        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        bool isPrime = false;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = true;
                break;
            }
        }

        return isPrime;
    }

    public static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));

            CheckPrime(23);
            Console.WriteLine("23 is prime.");

            CheckPrime(33);
            Console.WriteLine("33 is prime.");

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred! " + ex.Message);
        }
    }
}
