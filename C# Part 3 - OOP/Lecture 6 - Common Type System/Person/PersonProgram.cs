using System;

class PersonProgram
{
    static void Main()
    {
        Person pesho = new Person("Pesho");
        Person gosho = new Person("Gosho", 24);
        Person misho = new Person("Misho");

        Console.WriteLine(pesho);
        Console.WriteLine(gosho);
        Console.WriteLine(misho);
    }
}