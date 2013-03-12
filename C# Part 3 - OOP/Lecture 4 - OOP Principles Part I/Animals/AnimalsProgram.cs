//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//Kittens and tomcats are cats. All animals are described by age, name and sex.
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal
//using a static method (you may use LINQ).

using System;
using System.Linq;

class Animals
{
    static void Main()
    {
        //Dogs
        Animal[] dogs = new Dog[] 
        { 
            new Dog("Pesho", 5, Gender.male),
            new Dog("Kiki", 5, Gender.female),
            new Dog("Reks", 6, Gender.male) 
        };

        Console.WriteLine("The average age of the dogs is {0:F2} years.", Animal.AverageAge(dogs));
        Console.Write("{0} said: ", dogs[0].Name);
        dogs[0].ProduceSound();
        Console.WriteLine();

        //Frogs
        Animal[] frogs = new Frog[] 
        { 
            new Frog("Goshko", 2, Gender.male),
            new Frog("Mimi", 1, Gender.female) 
        };

        Console.WriteLine("The average age of the frogs is {0:F2} years.", Animal.AverageAge(frogs));
        Console.Write("{0} said: ", frogs[0].Name);
        frogs[0].ProduceSound();
        Console.WriteLine();

        //Cats
        Animal[] cats = new Cat[] 
        { 
            new Cat("Milka", 5, Gender.female),
            new Cat("Rasputin", 2, Gender.male) 
        };

        Console.WriteLine("The average age of the cats is {0:F2} years.", Animal.AverageAge(cats));
        Console.Write("{0} said: ", cats[0].Name);
        cats[0].ProduceSound();
        Console.WriteLine();

        //Kittens
        Animal[] kittens = new Kitten[] 
        { 
            new Kitten("Raina", 4),
            new Kitten("Mimi", 5) 
        };

        Console.WriteLine("The average age of the kittens is {0:F2} years.", Animal.AverageAge(kittens));
        Console.Write("{0} said: ", kittens[0].Name);
        kittens[0].ProduceSound();
        Console.WriteLine();

        //Tomcats
        Animal[] tomcats = new Tomcat[] 
        { 
            new Tomcat("Razvogor", 5),
            new Tomcat("Tom", 6) 
        };

        Console.WriteLine("The average age of the tomcats is {0:F2} years.", Animal.AverageAge(tomcats));
        Console.Write("{0} said: ", tomcats[0].Name);
        tomcats[0].ProduceSound();
        Console.WriteLine();
    }
}