using System;

class Worker : Human
{
    public decimal WeekSalary { get; set; }
    public int WorkHoursPerDay { get; set; }

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal MoneyPerHour()
    {
        return (WeekSalary / WorkHoursPerDay / 5);
    }
}