//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Threading;

public delegate void TimerDelegate(string message, int seconds, int times);

class Timer
{
    private static void TimerMethod(string message, int seconds, int times)
    {
        if (times < 0)
        {
            while (true)
            {
                Console.WriteLine(message);
                Thread.Sleep(seconds * 1000);
            }
        }
        else
        {
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine("{0}/{1} - {2}", i, times, message);
                Thread.Sleep(seconds * 1000);
            }
        }
    }

    static void Main()
    {
        //message, seconds, times. If times is < 0 method will be infinite
        TimerDelegate del = TimerMethod;
        del("1 second sleep time.", 1, 4);
        del("2 seconds sleep time.", 2, 2);
        del("3 seconds sleep time.", 3, 1);
    }
}