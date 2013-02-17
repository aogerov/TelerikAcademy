using System;

    class Employee
    {
        static void Main()
        {
            string firstName = "Alexander";
            string familyName = "Gerov";
            byte age = 31;
            bool genderMale = true;
            long IDNumber = 10934287103;
            int employeeNumber = 27560230;

            string gender;
            if (genderMale)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            Console.WriteLine("Name: {0}\nAge: {1}\nGender: {2}\nID Number: {3}\nEmployee number: {4}",
                (firstName + " " + familyName), age, gender, IDNumber, employeeNumber);
        }
    }
