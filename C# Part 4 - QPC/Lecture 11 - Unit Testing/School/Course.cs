using System;
using System.Collections.Generic;

namespace Education
{
    public class Course
    {
        private List<Student> students = new List<Student>();

        public Course(List<Student> students)
        {
            if (students == null)
            {
                throw new ArgumentNullException("Student list can't be null.");
            }

            if (students.Count == 0)
            {
                throw new ArgumentException("Student list length can't be 0.");
            }

            if (students.Count > 30)
            {
                throw new ArgumentException("Course can't have more than 30 students.");
            }

            this.students = students;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can't have null value.");
            }

            if (this.students.Count == 30)
            {
                throw new ArgumentOutOfRangeException("Course is full. You can't add more than 30 students.");
            }

            this.students.Add(student);
        }
    }
}
