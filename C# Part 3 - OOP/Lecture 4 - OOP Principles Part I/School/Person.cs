using System;

class Person
{
    protected string Name { get; private set; }

    protected Person(string name)
    {
        this.Name = name;
    }
}