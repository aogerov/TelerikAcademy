using System;

class TestProgram
{
    static void Main()
    {
        Student[] students = new Student[] { 
            new Student {FirstName = "Boris", LastName = "Gerov", Age = 25},
            new Student {FirstName = "Niki", LastName = "Kostov", Age = 18},
            new Student {FirstName = "Mila", LastName = "Antonova", Age = 26},
            new Student {FirstName = "Mila", LastName = "Daskalova", Age = 24},
            new Student {FirstName = "Alexander", LastName = "Angelov", Age = 17},
        };

        Console.WriteLine("All with first name before its last name alphabetically:");

        foreach (var student in FirstBeforeLastName.Find(students))
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        Console.WriteLine("\r\nAll students with age between 18 and 24:");

        foreach (var student in AgeBetween.Find(students))
        {
            Console.WriteLine("Name: {0} {1}, Age: {2}", student.FirstName, student.LastName, student.Age);
        }

        Console.WriteLine("\r\nSorted students by first name and last name in descending order with labda expression:");

        foreach (var student in SortByName.FindWithLambda(students))
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        Console.WriteLine("\r\nSorted students by first name and last name in descending order with LINQ:");

        foreach (var student in SortByName.FindWithLinq(students))
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}