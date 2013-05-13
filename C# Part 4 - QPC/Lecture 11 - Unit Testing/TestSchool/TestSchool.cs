using System;
using System.Collections.Generic;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorNullValue()
        {
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorForZeroLength()
        {
            School school = new School(new List<Course>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddCourseNullValue()
        {
            int coursesAmount = 1;
            int studentsPerCourseAmount = 10;
            List<Course> courses = this.GenerateCourseList(coursesAmount, studentsPerCourseAmount);
            School school = new School(courses);

            school.AddCourse(null);
        }

        [TestMethod]
        public void TestAddStudentRegular()
        {
            int coursesAmount = 1;
            int studentsPerCourseAmount = 10;
            List<Course> courses = this.GenerateCourseList(coursesAmount, studentsPerCourseAmount);
            School school = new School(courses);

            school.AddCourse(
                new Course(
                    new List<Student>() 
                    { 
                        new Student("Bai Ivan", 23456) 
                    }));

            Assert.AreEqual(school.Courses[1].Students[0].Name, "Bai Ivan");
            Assert.AreEqual(school.Courses[1].Students[0].UniqueNumber, 23456);
        }

        [TestMethod]
        public void TestSchoolListGetter()
        {
            int coursesAmount = 10;
            int studentsPerCourseAmount = 10;
            List<Course> courses = this.GenerateCourseList(coursesAmount, studentsPerCourseAmount);
            School school = new School(courses);
            List<Course> coursesForCompare = school.Courses;

            for (int i = 0; i < courses.Count; i++)
            {
                List<Student> students = courses[i].Students;
                List<Student> studentsForCompare = courses[i].Students;

                for (int k = 0; k < students.Count; k++)
                {
                    Assert.AreEqual(students[k].Name, studentsForCompare[k].Name);
                    Assert.AreEqual(students[k].UniqueNumber, studentsForCompare[k].UniqueNumber);
                }

                Assert.AreEqual(students.Count, studentsForCompare.Count);
            }

            Assert.AreEqual(courses.Count, coursesForCompare.Count);
        }

        private List<Course> GenerateCourseList(int coursesAmount, int studentsPerCourseAmount)
        {
            List<Course> courses = new List<Course>();

            for (int i = 0; i < coursesAmount; i++)
            {
                List<Student> students = new List<Student>();

                for (int k = 0; k < studentsPerCourseAmount; k++)
                {
                    Student student = new Student("Pesho" + i, 10000 + i);
                    students.Add(student);
                }

                Course course = new Course(students);
                courses.Add(course);
            }

            return courses;
        }
    }
}
