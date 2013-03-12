using System;

class Student : Human
{
    public int Grade { get; private set; }

    public Student(string firstName, string lastName, int grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }
}