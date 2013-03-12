using System;

class Cat : Animal
{
    public Cat(string name, int age, Gender gender) 
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meau-meau. I'm a {0}.", this.GetType().ToString().ToLower());
    }
}