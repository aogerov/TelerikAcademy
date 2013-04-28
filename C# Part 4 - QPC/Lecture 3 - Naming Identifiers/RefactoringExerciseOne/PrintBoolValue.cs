using System;

public class PrintBoolValue
{
    private const int MAX_COUNT = 6;

    public static void Input()
    {
        PrintBoolValue.Output printBool = new PrintBoolValue.Output();
        printBool.ConsolePrint(true);
    }

    private class Output
    {
        public void ConsolePrint(bool input)
        {
            string output = input.ToString();
            Console.WriteLine(output);
        }
    }
}