using System;
using System.Collections.Generic;

class Teacher : Person
{
    public List<Discipline> Disciplines { get; private set; }
    public string Comment { get; set; }

    public Teacher(string name, List<Discipline> disciplines, string comment = null) : base (name)
    {
        this.Disciplines = disciplines;
        this.Comment = comment;
    }
}