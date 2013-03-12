using System;

class Dog : Animal
{
    public Dog(string name, int age, Gender gender) 
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Bau-bau. I'm a {0}.", this.GetType().ToString().ToLower());
    }
}