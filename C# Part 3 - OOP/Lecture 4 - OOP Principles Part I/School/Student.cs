using System;

class Student : Person
{
    public int ClassNumber { get; private set; }
    public string Comment { get; set; }

    public Student(string name, int classNumber, string comment = null) : base (name)
    {
        this.ClassNumber = classNumber;
        this.Comment = comment;
    }
}