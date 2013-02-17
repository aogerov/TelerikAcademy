//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class NumberOfWorkdays
{
    static DateTime secondDate;
    static DateTime firstDate;

    private static void SwitchDates()
    {
        DateTime switchDate = secondDate;
        secondDate = firstDate;
        firstDate = switchDate;
    }

    static void Main()
    {
        Console.Write("Write some date in YYYY/MM/DD format: ");
        string[] date = Console.ReadLine().Split('/');
        //string[] date = "1981/05/08".Split('/');

        int year = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int day = int.Parse(date[2]);

        secondDate = new DateTime(year, month, day);

        firstDate = DateTime.Today;

        if (firstDate.Year > secondDate.Year)
        {
            SwitchDates();
        }
        else if (firstDate.Year == secondDate.Year)
        {
            if (firstDate.Month > secondDate.Month)
            {
                SwitchDates();
            }
            else if (firstDate.Month == secondDate.Month)
            {
                if (firstDate.Day > secondDate.Day)
                {
                    SwitchDates();
                }
            }
        }

        DateTime[] holydays = {
                                  new DateTime(2013, 3, 3),
                                  new DateTime(2013, 5, 8),
                                  new DateTime(2013, 10, 7),
                                  new DateTime(2013, 11, 9),
                                  new DateTime(2013, 6, 11),
                                  new DateTime(2013, 10, 26),
                                  new DateTime(2013, 5, 1)
                              };

        int workDays = 0;
        bool isHolyday = false;

        while ((firstDate.Year < secondDate.Year) || (firstDate.Month < secondDate.Month) || (firstDate.Day < secondDate.Day))
        {

            if ((firstDate.DayOfWeek == DayOfWeek.Saturday) || (firstDate.DayOfWeek == DayOfWeek.Sunday))
            {
                firstDate = firstDate.AddDays(1);
                continue;
            }
            else
            {
                foreach (var holyday in holydays)
                {
                    if ((holyday.Month == firstDate.Month) && (holyday.Month == firstDate.Month))
                    {
                        isHolyday = true;
                        break;
                    }
                }

                if (!isHolyday)
                {
                    workDays++;
                }
                else
                {
                    isHolyday = false;
                }
            }

            firstDate = firstDate.AddDays(1);
        }

        if (workDays == 1)
        {
            Console.WriteLine("\r\nThere is {0} workday in this period.\r\n", workDays);
        }
        else
        {
            Console.WriteLine("\r\nThere are {0} workdays in this period.\r\n", workDays);
        }
    }
}