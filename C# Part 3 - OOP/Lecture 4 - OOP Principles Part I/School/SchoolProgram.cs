//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number.
//Classes have unique text identifier. Teachers have name. Disciplines have name,
//number of lectures and number of exercises. Both teachers and students are people.
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
//encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

using System;
using System.Collections.Generic;

class School
{
    static void Main()
    {
        Class test = new Class(
            "11b",
            new List<Student> 
            {
                new Student("Gosho", 1),
                new Student("Misho", 2),
                new Student("Pesho", 3),
                new Student("Zorro", 4)
            },
            new List<Teacher> 
            {
                new Teacher("bai Ivan", 
                    new List<Discipline>
                    {
                        new Discipline("Math", 4, 4),
                        new Discipline("German", 2, 2)
                    },
                    "no coment here"),
                new Teacher("lelja Minka", 
                    new List<Discipline>
                    {
                        new Discipline("History", 2, 2),
                        new Discipline("Biology", 1, 1)
                    },
                    "good teacher")
            },
            "some comment");
    }
}