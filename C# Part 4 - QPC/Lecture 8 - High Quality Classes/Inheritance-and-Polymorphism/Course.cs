using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class Course
    {
        public string Name { get; set; }

        public string Teacher { get; set; }

        public IList<string> Students { get; set; }

        public Course(string name, string teacher = null, IList<string> students = null)
        {
            if (name == null || name == string.Empty)
            {
                throw new ArgumentException("Enter course name");
            }

            this.Name = name;
            this.Teacher = teacher;
            this.Students = students;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.Name);

            if (this.Teacher != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.Teacher);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
