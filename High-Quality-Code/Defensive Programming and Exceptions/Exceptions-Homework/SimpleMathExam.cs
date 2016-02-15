namespace Exceptions
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinCountOfProblemsSolved = 0;

        private const int MaxCountOfProblemsSolved = 2;

        private const int MinGrade = 2;

        private const int MaxGrade = 6;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinCountOfProblemsSolved || value > MaxCountOfProblemsSolved)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Problems solved must be a value between {0} and {1}.", MinCountOfProblemsSolved, MaxCountOfProblemsSolved));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            int actualGrade = 0;
            string comment = string.Empty;

            if (this.ProblemsSolved == MinCountOfProblemsSolved)
            {
                actualGrade = MinGrade;
                comment = "Bad result: nothing done.";
            }
            else if (this.ProblemsSolved == 1)
            {
                actualGrade = 4;
                comment = "Average result.";
            }
            else if (this.ProblemsSolved == MaxCountOfProblemsSolved)
            {
                actualGrade = MaxGrade;
                comment = "Excellent result: all done.";
            }

            var result = new ExamResult(actualGrade, MinGrade, MaxGrade, comment);
            return result;
        }
    }
}