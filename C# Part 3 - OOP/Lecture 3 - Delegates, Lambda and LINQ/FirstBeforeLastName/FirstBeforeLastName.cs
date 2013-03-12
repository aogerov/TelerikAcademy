//Write a method that from a given array of students finds all students
//whose first name is before its last name alphabetically. Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;

class FirstBeforeLastName
{
    public static IEnumerable<Student> Find(Student[] students)
    {
        return (from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student);
    }
}