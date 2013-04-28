using System;

class Reports
{
    public void PrintStatistics(double[] arr, int count)
    {
        double maxValue = Double.MinValue;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        }

        PrintMax(maxValue);

        double minValue = Double.MaxValue;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }

        PrintMin(minValue);

        double sumOfAll = 0;
        for (int i = 0; i < count; i++)
        {
            sumOfAll += arr[i];
        }

        PrintAvg(sumOfAll / count);
    }

    //the three methods below are not real, they are made so that the project can be build.
    void PrintMax(double max) { }
    void PrintMin(double min) { }
    void PrintAvg(double average) { }
}
