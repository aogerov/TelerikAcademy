using System;

class StudentProgram
{
    static void Main()
    {
        Student pesho = new Student
        {
            FirstName = "Pesho",
            SecondName = "Petrov",
            LastName = "Ivanov",
            SSN = "1231242319",
            PermanentAddress = "Tuturutkovo",
            MobilePhone = "112",
            EMail = "pesho@pesho.com",
            Course = 2,
            Speciality = Specialities.ComputerSystemsAndControl,
            Faculty = Faculties.ComputerSciece,
            University = Universities.TUSofia
        };

        Student pesho2 = new Student
        {
            FirstName = "Pesho",
            SecondName = "Petrov",
            LastName = "Ivanov",
            SSN = "1231242319",
            PermanentAddress = "Tuturutkovo",
            MobilePhone = "112",
            EMail = "pesho@pesho.com",
            Course = 2,
            Speciality = Specialities.ComputerSystemsAndControl,
            Faculty = Faculties.ComputerSciece,
            University = Universities.TUSofia
        };

        Student gosho = new Student
        {
            FirstName = "Gosho",
            SecondName = "Mihov",
            LastName = "Daskalov",
            SSN = "2342342354",
            PermanentAddress = "Sofia",
            MobilePhone = "166",
            EMail = "gosho@gosho.com",
            Course = 3,
            Speciality = Specialities.EastAsianCultures,
            Faculty = Faculties.Humanitarian,
            University = Universities.SofiaUniversity
        };

        Console.WriteLine("pesho == pesho2 -> {0}", pesho == pesho2);
        Console.WriteLine("pesho != pesho2 -> {0}", pesho != pesho2);
        Console.WriteLine();
        Console.WriteLine("pesho == gosho -> {0}", pesho == gosho);
        Console.WriteLine("pesho != gosho -> {0}", pesho != gosho);
        Console.WriteLine();
        Console.WriteLine(pesho);
        Console.WriteLine();
        Console.WriteLine("HashCode() of pesho: {0}", pesho.GetHashCode());

        Student cloneOfGosho = gosho.Clone() as Student;

        Console.WriteLine("\r\ngosho == cloneOfGosho -> {0}\r\n", gosho == cloneOfGosho);
        Console.WriteLine("Cloned gosho:\r\n");
        Console.WriteLine(cloneOfGosho);

        pesho2.SSN = "1031242319";
        cloneOfGosho.SSN = "1342342354";
    }
}