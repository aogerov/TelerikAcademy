//Define a class Student, which contains data about a student – first, middle and last name,
//SSN, permanent address, mobile phone, e-mail, course, specialty, university, faculty.
//Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//Add implementations of the ICloneable interface.
//The Clone() method should deeply copy all object's fields into a new object of type Student.

//Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
//and by social security number (as second criteria, in increasing order).

using System;

class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string LastName { get; set; }
    public string SSN { get; set; }
    public string PermanentAddress { get; set; }
    public string MobilePhone { get; set; }
    public string EMail { get; set; }
    public int Course { get; set; }
    public Specialities Speciality { get; set; }
    public Faculties Faculty { get; set; }
    public Universities University { get; set; }

    public override bool Equals(object obj)
    {
        Student student = obj as Student;

        if ((object) student == null)
        {
            return false;
        }

        if (!this.FirstName.Equals(student.FirstName))
        {
            return false;
        }

        if (!this.SecondName.Equals(student.SecondName))
        {
            return false;
        }

        if (!this.LastName.Equals(student.LastName))
        {
            return false;
        }

        if (!this.SSN.Equals(student.SSN))
        {
            return false;
        }

        if (!this.PermanentAddress.Equals(student.PermanentAddress))
        {
            return false;
        }

        if (!this.MobilePhone.Equals(student.MobilePhone))
        {
            return false;
        }

        if (!this.EMail.Equals(student.EMail))
        {
            return false;
        }

        if (this.Course != student.Course)
        {
            return false;
        }

        if (!this.Speciality.Equals(student.Speciality))
        {
            return false;
        }

        if (!this.Faculty.Equals(student.Faculty))
        {
            return false;
        }

        if (!this.University.Equals(student.University))
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return String.Format("First name: {0}\r\nSecond name: {1}\r\nLast name: {2}" +
            "\r\nSSN: {3}\r\nPermanent address: {4}\r\nMobile phone: {5}\r\nE-mail: {6}" +
            "\r\nCourse: {7}\r\nSpeciality: {8}\r\nFaculty: {9}\r\nUniversity: {10}",
            FirstName, SecondName, LastName, SSN, PermanentAddress, MobilePhone, EMail,
            Course, Speciality, Faculty, University);
    }

    public override int GetHashCode()
    {
        return (FirstName.GetHashCode() ^ LastName.GetHashCode());
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }

    public object Clone()
    {
        Student student = new Student();

        student.FirstName = this.FirstName;
        student.SecondName = this.SecondName;
        student.LastName = this.LastName;
        student.SSN = this.SSN;
        student.PermanentAddress = this.PermanentAddress;
        student.MobilePhone = this.MobilePhone;
        student.EMail = this.EMail;
        student.Course = this.Course;
        student.Speciality = this.Speciality;
        student.Faculty = this.Faculty;
        student.University = this.University;

        return student;
    }

    public int CompareTo(Student other)
    {
        if (this.FirstName == other.FirstName)
        {
            return String.Compare(this.SSN, other.SSN);
        }
        else
        {
            return String.Compare(this.FirstName, other.FirstName);
        }
    }
}