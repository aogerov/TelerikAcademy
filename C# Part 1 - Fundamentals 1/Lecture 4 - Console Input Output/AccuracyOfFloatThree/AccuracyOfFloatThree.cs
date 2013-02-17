using System;

class AccuracyOfFloatThree
{
    static void Main()
    {
        double number = 1;
        double tempNumber = 1;
        int divisor = 2;

        while (tempNumber > 0.001f)
        {
            tempNumber = 1.0 / divisor;
            if (divisor % 2 == 0)
            {
                number += tempNumber;
            }
            else
            {
                number -= tempNumber;
            }
            divisor++;
        }

        Console.WriteLine("The result of the calculation is: " + number);
    }
}