//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort
//the students by first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

class SortByName
{
    public static IEnumerable<Student> FindWithLambda(Student[] students)
    {
        var results = students
            .OrderByDescending(student => student.FirstName)
            .ThenByDescending(student => student.LastName);
        return results;
    }

    public static IEnumerable<Student> FindWithLinq(Student[] students)
    {
        var results = (from student in students
                       orderby student.FirstName descending, student.LastName descending
                       select student);
        return results;
    }
}