using System;

class DepositAccount : Account, IWithdrawMoney
{
    public DepositAccount(string customer, decimal balance, decimal interest, CustomerType customerType)
        : base(customer, balance, interest, customerType) { }

    public override decimal CalculateInterest(int numberOfMonths)
    {
        if (this.Balance < 1000)
        {
            return 0;
        }
        else
        {
            return (Balance * ((Interest / 12) * numberOfMonths));
        }
    }

    public void DrawMoney(decimal amount)
    {
        if (amount > this.Balance)
        {
            throw new ArgumentException("Not enought money for the transaction");
        }
        else
        {
            this.Balance -= amount;
        }
    }
}