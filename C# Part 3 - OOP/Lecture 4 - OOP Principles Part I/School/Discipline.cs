using System;

class Discipline
{
    public string Name { get; private set; }
    public int NumberOfLectures { get; private set; }
    public int NumberOfExercises { get; private set; }
    public string Comment { get; set; }

    public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment = null)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
        this.Comment = comment;
    }
}