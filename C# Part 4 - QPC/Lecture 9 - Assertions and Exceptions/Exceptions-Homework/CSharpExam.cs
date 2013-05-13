using System;

public class CSharpExam : Exam
{
    public int Score
    {
        get
        {
            return this.Score;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Score can't have negative value.");
            }

            this.Score = value;
        }
    }

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException("Score has to be in the range 1 to 99 inclusive.");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
