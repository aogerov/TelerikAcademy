using System;
using System.Collections.Generic;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorNullValue()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorForZeroLength()
        {
            Course course = new Course(new List<Student>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorForTooManyStudents()
        {
            int amount = 31;
            List<Student> students = this.GenerateStudentList(amount);
            Course course = new Course(students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddStudentNullValue()
        {
            int amount = 1;
            List<Student> students = this.GenerateStudentList(amount);
            Course course = new Course(students);
            
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddStudentMaxRange()
        {
            int amount = 30;
            List<Student> students = this.GenerateStudentList(amount);
            Course course = new Course(students);

            course.AddStudent(new Student("Gosho", 55555));
        }

        [TestMethod]
        public void TestAddStudentRegular()
        {
            int amount = 1;
            List<Student> students = this.GenerateStudentList(amount);
            Course course = new Course(students);

            course.AddStudent(new Student("Bobi", 44444));
            Assert.AreEqual(course.Students[1].Name, "Bobi");
            Assert.AreEqual(course.Students[1].UniqueNumber, 44444);
        }

        [TestMethod]
        public void TestStudentListGetter()
        {
            int amount = 10;
            List<Student> students = this.GenerateStudentList(amount);
            Course course = new Course(students);
            List<Student> studentsForCompare = course.Students;

            for (int i = 0; i < students.Count; i++)
            {
                Assert.AreEqual(students[i].Name, studentsForCompare[i].Name);
                Assert.AreEqual(students[i].UniqueNumber, studentsForCompare[i].UniqueNumber);
            }

            Assert.AreEqual(students.Count, studentsForCompare.Count);
        }

        private List<Student> GenerateStudentList(int count)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                Student student = new Student("Pesho" + i, 10000 + i);
                students.Add(student);
            }

            return students;
        }
    }
}
