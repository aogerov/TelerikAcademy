//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
//by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;

class InvalidRangeExceptionProgram
{
    static void Main()
    {
        int startInteger = 1;
        int endInteger = 100;
        DateTime startDate = new DateTime(1980, 1, 1);
        DateTime endDate = new DateTime(2013, 12, 31);

        //test number range
        Console.WriteLine("Enter some number in the range [1 ... 100]");

        try
        {
            while (true)
            {
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine("Correct number! You've entered {0}", number);
                }
                else
                {
                    throw new InvalidRangeException<int>(startInteger, endInteger, String.Format("Entered number is {0}", number));
                }
            }
        }
        catch (InvalidRangeException<int>)
        {
            Console.WriteLine("InvalidRangeException<int> - program continues to Date tests.\r\n");
        }

        //test date range
        Console.WriteLine("Enter some date in the range [1.1.1980 … 31.12.2013]");
        try
        {
            while (true)
            {
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                if (date >= startDate && date <= endDate)
                {
                    Console.WriteLine("Correct date! You've entered {0}.{1}.{2}", date.Day, date.Month, date.Year);
                }
                else
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate, String.Format("Entered date is {0}", date));
                }
            }
        }
        catch (InvalidRangeException<DateTime>)
        {
            Console.WriteLine("InvalidRangeException<DateTime> - program terminates.");
        }

        Console.WriteLine();
    }
}
