using System;

class CompanyInformation
{
    static void Main()
    {
        string input;
        Console.Write("Enter company name: ");
        string name = Console.ReadLine();

        Console.Write("Enter company address: ");
        string address = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        input = Console.ReadLine();
        int phoneNumber = int.Parse(input);

        Console.Write("Enter company fax number: ");
        input = Console.ReadLine();
        int faxNumber = int.Parse(input);

        Console.Write("Enter company website: ");
        string webSite = Console.ReadLine();

        Manager manager = new Manager();
        Console.Write("Enter company manager's first name: ");
        manager.FirstName = Console.ReadLine();

        Console.Write("Enter company manager's last name: ");
        manager.LastName = Console.ReadLine();

        Console.Write("Enter company manager's age: ");
        input = Console.ReadLine();
        manager.Age = int.Parse(input);

        Console.Write("Enter company manager's phone number: ");
        input = Console.ReadLine();
        manager.PhoneNumber = int.Parse(input);

        Console.WriteLine("\r\nCompany info: \r\nCompany name: {0}\r\nAddress: {1}\r\nPhone number: {2}\r\nFax number:" +
            "{3}\r\nWeb site: {4}\r\n\r\nManager's info:\r\nManager's name: {5} {6}\r\nAge: {7}\r\nPhone number: {8}",
            name, address, phoneNumber, faxNumber, webSite, manager.FirstName, manager.LastName, manager.Age, manager.PhoneNumber);
    }

    class Manager
    {
        private string firstName;
        private string lastName;
        private int age;
        private int phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}