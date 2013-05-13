using System;

public class ExamResult
{
    public int Grade
    {
        get
        {
            return this.Grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade can't be negative.");
            }
        }
    }

    public int MinGrade
    {
        get
        {
            return this.MinGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Min grade can't be negative.");
            }
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.MinGrade;
        }

        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade can't be smaller or equal to min grade.");
            }
        }
    }

    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
