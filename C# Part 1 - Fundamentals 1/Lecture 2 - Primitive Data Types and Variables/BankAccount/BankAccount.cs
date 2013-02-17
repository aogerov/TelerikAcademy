using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Alexander";
        string middleName = "Oleg";
        string lastName = "Gerov";
        decimal amountOfMoney = 3478.68M;
        string bankName = "Postbank";
        string IBANCountry = "BG";
        byte IBANCheck = 55;
        string IBANId = "BPBI";
        long IBANAccount = 79401046370301;
        string BICBank = "BPBI";
        string BICCountry = "BG";
        string BICCity = "SF";
        long cardOne = 23951846182746;
        long cardTwo = 35394887612047;
        long cardThree = 59238717893401;

        string holderName = firstName + " " + middleName + " " + lastName;
        string ballance = amountOfMoney + "\u20AC";
        string IBAN = IBANCountry + IBANCheck + IBANId + IBANAccount;
        string BIC = BICBank + BICCountry + BICCity;

        Console.WriteLine("Holder name: {0}\nBallance: {1}\nBank: {2}\nIBAN: {3}\nBIC: {4}\nCredit card: {5}" +
        "\nCredit card: {6}\nCredit card: {7}", holderName, ballance, bankName, IBAN, BIC, cardOne, cardTwo, cardThree);
    }
}
