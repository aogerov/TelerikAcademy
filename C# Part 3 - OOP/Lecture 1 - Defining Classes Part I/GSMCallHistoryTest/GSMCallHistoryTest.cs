using System;
using GSM;

class GSMCallHistoryTest
{
    static void Main()
    {
        //Create an instance of the GSM class
        Gsm gsm = new Gsm("500", "Nokia", 123.4M, "Alexander", 
            new Battery("Ak7-03", 73.5, 12.4, BatteryType.NiMH), new Display("200 x 300", 256000));

        //Add few calls
        gsm.AddCall(new Call(new DateTime(2013, 02, 28, 12, 34, 18), "0888166166", 123));
        gsm.AddCall(new Call(new DateTime(2013, 02, 28, 13, 43, 26), "0879863413", 234));
        gsm.AddCall(new Call(new DateTime(2013, 02, 28, 17, 18, 56), "0896623784", 47));

        //Display the information about the calls
        foreach (var call in gsm.GetCallList())
        {
            Console.WriteLine(call);
        }

        //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history
        Console.Write("Total price: ");
        Console.WriteLine("{0:C}\r\n", gsm.CalculateCallsPrice(0.37M));

        //Remove the longest call from the history and calculate the total price again
        gsm.RemoveCall(gsm.LongestCallIndex());

        Console.Write("Price without the longest call: ");
        Console.WriteLine("{0:C}\r\n", gsm.CalculateCallsPrice(0.37M));

        //Finally clear the call history and print it
        gsm.ClearCallHistory();

        Console.Write("After clearing the call history: ");
        Console.WriteLine("{0:C}\r\n", gsm.CalculateCallsPrice(0.37M));
    }
}