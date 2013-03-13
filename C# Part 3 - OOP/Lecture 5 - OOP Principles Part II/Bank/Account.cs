using System;

class Account : ICalculateInterest, IDepositMoney
{
    public string Customer { get; protected set; }
    public decimal Balance { get; protected set; }
    public decimal Interest { get; protected set; }
    public CustomerType CustomerType { get; protected set; }

    protected Account(string customer, decimal balance, decimal interest, CustomerType customerType)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.Interest = interest / 100;
        this.CustomerType = customerType;
    }

    public void DepositMoney(decimal amount)
    {
        this.Balance += amount;
    }

    public virtual decimal CalculateInterest(int numberOfMonths)
    {
        throw new NotImplementedException();
    }
}