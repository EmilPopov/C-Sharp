namespace Exceptions
{
    using System;

    public class ExamResult
    {
        private const int MinValueOfMinGrade = 0;

        private int grade;

        private int minGrade;

        private int maxGrade;

        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.MinGrade = minGrade;
            this.Grade = grade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("Grade must be greater than min grade.");
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
                if (value < MinValueOfMinGrade)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Min grade must be a value greater than or equal to {0}.", MinValueOfMinGrade));
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
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("Max grade must be greater than min grade.");
                }

                this.maxGrade = value;
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
                    throw new ArgumentException("Comments must be a non-empty string.");
                }

                this.comments = value;
            }
        }
    }
}