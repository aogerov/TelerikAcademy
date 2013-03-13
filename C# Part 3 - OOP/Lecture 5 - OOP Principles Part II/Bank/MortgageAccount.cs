using System;

class MortgageAccount : Account
{
    public MortgageAccount(string customer, decimal balance, decimal interest, CustomerType customerType)
        : base(customer, balance, interest, customerType) { }

    public override decimal CalculateInterest(int numberOfMonths)
    {
        if (CustomerType == CustomerType.company)
        {
            if (numberOfMonths <= 12)
            {
                return (Balance * ((Interest / 2 / 12) * numberOfMonths));
            }
            else
            {
                return (Balance * ((Interest / 2 / 12) * 12))
                    + (Balance * ((Interest/ 12) * (numberOfMonths - 12)));
            }
        }
        else
        {
            if (numberOfMonths <= 6)
            {
                return 0;
            }
            else
            {
                return (Balance * ((Interest / 12) * numberOfMonths));
            }
        }
    }
}