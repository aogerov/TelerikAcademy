using System;
using System.Collections.Generic;

namespace Education
{
    public class School
    {
        private List<Course> courses = new List<Course>();
        
        public School(List<Course> courses)
        {
            if (courses == null)
            {
                throw new ArgumentNullException("Cources list can't be null.");
            }

            if (courses.Count == 0)
            {
                throw new ArgumentException("Courses count can't be 0.");
            }

            this.courses = courses;
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can't have null value.");
            }

            this.courses.Add(course);
        }
    }
}
