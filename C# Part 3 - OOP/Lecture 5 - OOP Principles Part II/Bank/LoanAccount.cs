using System;

class LoanAccount : Account
{
    public LoanAccount(string customer, decimal balance, decimal interest, CustomerType customerType)
        : base(customer, balance, interest, customerType) { }

    public override decimal CalculateInterest(int numberOfMonths)
    {
        if (CustomerType == CustomerType.company)
        {
            if (numberOfMonths <= 2)
            {
                return 0;
            }
            else
            {
                return (Balance * ((Interest / 12) * (numberOfMonths - 2)));
            }
        }
        else
        {
            if (numberOfMonths <= 3)
            {
                return 0;
            }
            else
            {
                return (Balance * ((Interest / 12) * (numberOfMonths - 3)));
            }
        }
    }
}