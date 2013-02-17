using System;
using System.Text;

class DancingBits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        
        StringBuilder allBits = new StringBuilder();
        int counter = 0;

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            allBits.Append(Convert.ToString(number, 2));
        }

        string allBitsString = allBits.ToString();
        string[] zero = allBitsString.Split('1');
        string[] one = allBitsString.Split('0');

        foreach (var item in zero)
        {
            if (item.Length == K)
            {
                counter++;
            }
        }

        foreach (var item in one)
        {
            if (item.Length == K)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}