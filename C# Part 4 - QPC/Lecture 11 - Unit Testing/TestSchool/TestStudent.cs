using System;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorNameNullValue()
        {
            Student student = new Student(null, 1234);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructorNameEmptyString()
        {
            Student student = new Student(string.Empty, 1234);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorUniqueNumberNegativeVaue()
        {
            Student student = new Student("Pesho", -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorUniqueNumberLowRange()
        {
            Student student = new Student("Pesho", 999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorUniqueNumberAboveRange()
        {
            Student student = new Student("Pesho", 100000);
        }

        [TestMethod]
        public void TestNameGetter()
        {
            Student student = new Student("Pesho", 10000);
            Assert.AreEqual("Pesho", student.Name);
        }

        [TestMethod]
        public void TestUniqueNumberGetter()
        {
            Student student = new Student("Pesho", 10000);
            Assert.AreEqual(10000, student.UniqueNumber);
        }
    }
}
