//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;

class AgeBetween
{
    public static IEnumerable<Student> Find(Student[] students)
    {
        return (from student in students
                where student.Age >= 18 && student.Age <= 24
                select student);
    }
}