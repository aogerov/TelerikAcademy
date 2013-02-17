using System;

class AfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;
        if (int.TryParse(input, out age))
        {
            age = int.Parse(input);
            Console.WriteLine("Your current age is {0}. After 10 years You'll be {1} years old.", age, age + 10);
        }
        else
        {
            Console.WriteLine("Error! Enter your age!");
        }
    }
}
