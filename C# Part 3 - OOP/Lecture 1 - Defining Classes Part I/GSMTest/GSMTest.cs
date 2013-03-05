using System;
using GSM;

class GSMTest
{
    static void Main()
    {
        Gsm[] gsms = new Gsm[]
            {
                new Gsm("500", "Nokia", 123.4M, "Alexander", 
                    new Battery("Ak7-03", 73.5, 12.4, BatteryType.NiMH), new Display("200 x 300", 256000)),
                
                    new Gsm("C5", "Nokia", 143.4M, "Pesho", 
                    new Battery("BP-13/42", 78.5, 8.4, BatteryType.NiCd), new Display("300 x 420", 128000))
            };

        Console.WriteLine(Gsm.IPhone4S);

        foreach (var gsm in gsms)
        {
            Console.WriteLine(gsm);
        }
    }
}