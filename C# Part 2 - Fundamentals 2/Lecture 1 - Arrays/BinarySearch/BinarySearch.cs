//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        int[] numbers;
        string[] nums;
        string input;
        int startIndex;
        int endIndex;
        int indexPosition;
        bool foundNumber;
        int unknownNumberToFind;
        int unknownNumberToFindIndex = 0;

        //array initialization
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        input = Console.ReadLine();
        //input = "0 2 4 6 8 10 12 14 16 18";
        //input = "6 3 1 34 -4 0 4 2 5 8";

        nums = input.Split(' ');
        numbers = new int[nums.Length];
        try
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(nums[index]);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Wrong input! Enter only numbers with one space between.");
            return;
        }

        //number initialization
        Console.Write("Enter some number: ");
        input = Console.ReadLine();
        //input = "19";

        if (int.TryParse(input, out unknownNumberToFind))
        {
            unknownNumberToFind = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input! Program terminates.");
        }

        //sort Array
        Array.Sort(numbers);

        //scan for number
        if ((unknownNumberToFind < numbers[0]) || (unknownNumberToFind > numbers[numbers.Length - 1]))
        {
            foundNumber = false;

            if (unknownNumberToFind < numbers[0])
            {
                unknownNumberToFindIndex = 0;
            }
            else
            {
                unknownNumberToFindIndex = numbers.Length - 1;
            }
        }
        else
        {
            startIndex = 0;
            endIndex = numbers.Length - 1;

            while (true)
            {
                indexPosition = startIndex + ((endIndex - startIndex) / 2);

                if (unknownNumberToFind == numbers[indexPosition])
                {
                    foundNumber = true;
                    unknownNumberToFindIndex = indexPosition;
                    break;
                }
                else
                {
                    if (unknownNumberToFind < numbers[indexPosition])
                    {
                        if ((endIndex - startIndex) % 2 == 0)
                        {
                            endIndex = indexPosition;
                        }
                        else
                        {
                            endIndex = indexPosition + 1;
                        }
                    }
                    else
                    {
                        if ((endIndex - startIndex) % 2 == 0)
                        {
                            startIndex = indexPosition;
                        }
                        else
                        {
                            startIndex = indexPosition + 1;
                        }
                    }

                    if ((numbers[indexPosition] < unknownNumberToFind) && (unknownNumberToFind < numbers[indexPosition + 1]))
                    {
                        foundNumber = false;
                        unknownNumberToFindIndex = indexPosition;
                        break;
                    }
                }
            }
        }

        //print output
        if (foundNumber)
        {
            Console.WriteLine("\r\nNumber {0} is found at index {1}", unknownNumberToFind, unknownNumberToFindIndex);
        }
        else
        {
            Console.WriteLine("\r\nNumber {0} is NOT found. Algorithm index output -{1}", unknownNumberToFind, unknownNumberToFindIndex + 1);
        }
    }
}