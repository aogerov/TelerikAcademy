using System;
using System.Linq;

abstract class Animal : ISound
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public Gender Gender { get; private set; }

    protected Animal(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public virtual void ProduceSound()
    {
        Console.WriteLine("I'm {0} and i make sound.", this.GetType());
    }

    public override string ToString()
    {
        return String.Format("Name: {0}, Age: {1}, Gender: {2}", Name, Age, Gender);
    }

    public static double AverageAge(Animal[] animals)
    {
        return animals.Average(animal => animal.Age);
    }
}