using System;

namespace Education
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name can't have null value.");
            }

            if (name == string.Empty)
            {
                throw new ArgumentException("Name can't be empty.");
            }

            if (uniqueNumber < 10000)
            {
                throw new ArgumentOutOfRangeException("Unique number can't be lower than 10000.");
            }

            if (uniqueNumber > 99999)
            {
                throw new ArgumentOutOfRangeException("Unique number can't be bigger than 99999.");
            }

            this.name = name;
            this.uniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
        }
    }
}
