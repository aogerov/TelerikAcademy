//Write a program that reads a text file containing a square matrix of numbers
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. 

using System;
using System.IO;

class MaxSumArea
{
    static int[,] numbers;

    static void InitializeArray(string line, int lineCounter)
    {
        string[] nums = line.Split(' ');

        for (int index = 0; index < numbers.GetLength(1); index++)
        {
            numbers[lineCounter, index] = int.Parse(nums[index]);
        }
    }

    static void FileReader(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string line = reader.ReadLine();
            
            int length = int.Parse(line);
            
            numbers = new int[length, length];

            int lineCounter = 0;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                
                InitializeArray(line, lineCounter);

                lineCounter++;
            }
        }
    }

    static int CalculateSquare(int row, int col)
    {
        int result = 0;

        for (int i = row; i <= row + 1; i++)
        {
            for (int j = col; j <= col + 1; j++)
            {
                result = result + numbers[i, j];
            }
        }

        return result;
    }

    static int CalculateResult()
    {
        int result;
        int maxResult = int.MinValue;

        for (int row = 0; row < numbers.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < numbers.GetLength(1) - 1; col++)
            {
                result = CalculateSquare(row, col);

                if (maxResult < result)
                {
                    maxResult = result;
                }
            }
        }

        return maxResult;
    }

    static void FileWriter(string resultPath, int result)
    {
        using (StreamWriter writer = new StreamWriter(resultPath))
        {
            writer.Write(result);

            Console.WriteLine("File created!\r\n");
        }
    }

    static void Main()
    {
        string path = @"..\..\input.txt";
        string resultPath = @"..\..\result.txt";

        try
        {
            FileReader(path);
            FileWriter(resultPath, CalculateResult());
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Error! File not found exeption!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Error! Directory not found exeption!");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Error! I/O exeption!");
        }
        catch (Exception)
        {
            Console.Error.WriteLine("Fatal error!");
        }
    }
}