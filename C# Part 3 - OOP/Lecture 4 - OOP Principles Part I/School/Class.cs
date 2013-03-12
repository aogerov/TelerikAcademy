using System;
using System.Collections.Generic;

class Class
{
    public string Identifier { get; private set; }
    public List<Student> Students { get; private set; }
    public List<Teacher> Teachers { get; private set; }
    public string Comment { get; set; }

    public Class(string identifier, List<Student> students, List<Teacher> teachers, string comment = null)
    {
        this.Identifier = identifier;
        this.Students = students;
        this.Teachers = teachers;
        this.Comment = comment;
    }
}