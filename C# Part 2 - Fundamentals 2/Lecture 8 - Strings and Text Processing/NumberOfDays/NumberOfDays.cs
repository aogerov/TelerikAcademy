//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//      Enter the first date: 27.02.2006
//      Enter the second date: 3.03.2004
//      Distance: 4 days

using System;

class NumberOfDays
{
    static DateTime firstDate;
    static DateTime secondDate;

    static void SwitchDatesIfNeeded()
    {
        if (firstDate > secondDate)
        {
            DateTime switchDate = new DateTime();

            switchDate = firstDate;
            firstDate = secondDate;
            secondDate = switchDate;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter first date: ");
        //string firstDateInput = Console.ReadLine();
        string firstDateInput = "27.01.2014";

        Console.WriteLine("Enter second date: ");
        //string secondDateInput = Console.ReadLine();
        string secondDateInput = "5.02.2013";

        firstDate = DateTime.Parse(firstDateInput);

        secondDate = DateTime.Parse(secondDateInput);

        SwitchDatesIfNeeded();

        int distance = 0;

        while (firstDate < secondDate)
        {
            firstDate = firstDate.AddDays(1);
            distance++;
        }

        Console.WriteLine("Distance: {0} days", distance);
    }
}