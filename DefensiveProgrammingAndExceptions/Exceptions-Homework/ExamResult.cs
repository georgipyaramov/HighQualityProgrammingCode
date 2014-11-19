using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("The maximal grade should be bigger than the minimal grade");
        }
        

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade {
        get
        {
            return this.grade;
        }
        private set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The grade cannot be negative!");
            }

            this.grade = value;
        }
    }
    public int MinGrade 
    {
        get 
        {
            return this.minGrade;
        } 
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The minimal grade cannot be negative!");
            }

            this.minGrade = value;
        }
    }
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        } 
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The maxsimal grade cannot be negative!");
            }

            this.minGrade = value;
        }
    }
    public string Comments 
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Comments are obligatory! Please write some!");
            }
        }
    }
}
