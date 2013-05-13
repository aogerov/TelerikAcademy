using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved
    {
        get
        {
            return this.ProblemsSolved;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Solved problems can't have negative value.");
            }

            this.ProblemsSolved = value;
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            throw new ArgumentException("Solved problems can't have negative value.");
        }

        if (problemsSolved > 10)
        {
            throw new ArgumentException("Solved problems can't have value bigger tha 10.");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        throw new ArgumentOutOfRangeException("Invalid number of problems solved!");
    }
}
