//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value.
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

using System;

class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        return String.Format("Name: {0}, Age: {1}", this.Name,
            this.Age == null ? "<not specified>" : this.Age.ToString());
    }
}