//Define abstract class Human with first name and last name. Define new class Student which is derived
//from Human and has new field – grade.Define class Worker derived from Human with new property WeekSalary
//and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
//Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students
//and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

using System;
using System.Linq;
using System.Collections.Generic;

class Humans
{
    static void Main()
    {
        //setting list of students
        List<Student> students = new List<Student> 
        {
            new Student("Anton", "Mihailov", 5),
            new Student("Dimitar", "Georgiev", 8),
            new Student("Mila", "Janeva", 4),
            new Student("Boris", "Andreev", 9),
            new Student("Gosho", "Petrov", 1),
            new Student("Ljubka", "Zevzekova", 10),
            new Student("Zoika", "Koleva", 2),
            new Student("Iva", "Todorova", 7),
            new Student("Kiril", "Viktorov", 3),
            new Student("Nevena", "Boneva", 6)
        };

        //sorting students by grade
        var sortedStudents = (from student in students
                              orderby student.Grade
                              select student);

        //printing students
        Console.WriteLine("Students by grade:");

        foreach (var student in sortedStudents)
        {
            Console.WriteLine("Name: {0} {1}, Grade: {2}", student.FirstName, student.LastName, student.Grade);
        }

        //setting sorted workers
        List<Worker> workers = new List<Worker>
        {
            new Worker("Viktor", "Elenkov", 540, 9),
            new Worker("Emilia", "Ivanova", 380, 8),
            new Worker("Oleg", "Ljutov", 760, 5),
            new Worker("Pesho", "Nikolov", 625, 7),
            new Worker("Radost", "Orlinova", 250, 8),
            new Worker("Svetljo", "Hipodilov", 430, 6),
            new Worker("Todor", "Rangelov", 565, 8),
            new Worker("Finka", "Stavreva", 485, 7),
            new Worker("Hristo", "Tsachev", 725, 6),
            new Worker("Mila", "Daskalova", 715, 10)
        };

        //sorting workers by money per hour
        var sortedWorkers = (from worker in workers
                             orderby worker.MoneyPerHour() descending
                             select worker);

        //printing sorted workers
        Console.WriteLine("\r\nWorkers by money per hour:");

        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine("Name: {0} {1}, Money per hour: {2:C}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
        }

        //merging students and workers in new list
        List<Human> humans = new List<Human>(students.Count + workers.Count);

        foreach (var student in students)
        {
            humans.Add(student);
        }

        foreach (var worker in workers)
        {
            humans.Add(worker);
        }

        //sorting humans by name
        var sortedHumans = (from human in humans
                            orderby human.FirstName, human.LastName
                            select human);

        //printing sorted humans
        Console.WriteLine("\r\nMerged and sorted by name:");

        foreach (var human in sortedHumans)
        {
            Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
        }
    }
}