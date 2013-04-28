using System;

public class MainClass
{
    private enum Gender 
    { 
        Male, 
        Female 
    }

    public void CreateHuman(int age)
    {
        Person newPerson = new Person();
        
        newPerson.Age = age;
        
        if (age % 2 == 0)
        {
            newPerson.Name = "Batman";
            newPerson.Gender = Gender.Male;
        }
        else
        {
            newPerson.Name = "Cat";
            newPerson.Gender = Gender.Female;
        }
    }

    private class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}