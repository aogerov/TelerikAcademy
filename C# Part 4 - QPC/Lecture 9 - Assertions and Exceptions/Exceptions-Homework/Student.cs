using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName
    {
        get
        {
            return this.FirstName;
        }

        set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentNullException("First name can't be empty.");
            }

            this.FirstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.LastName;
        }

        set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentNullException("Last name can't be empty.");
            }

            this.LastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get
        {
            return this.Exams;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Last name can't be null.");
            }

            this.Exams = value;
        }
    }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("List has null value.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("List is empty.");
        }

        IList<ExamResult> results = new List<ExamResult>();

        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            // Cannot calculate average on missing exams
            throw new ArgumentNullException("List has null value.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("List is empty.");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
