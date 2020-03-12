using System;

namespace QuizTime
{
    /// <summary>
    ///     Base question type.  Inherit from this to design a question.
    /// </summary>
    public abstract class Question
    {
        /// <summary>
        ///     Question as it will be asked to the user.
        /// </summary>
        public string QuestionText { get; private set; }

        /// <summary>
        ///     Any additional instructions on how to answer the question.
        /// </summary>
        public string Instructions { get; protected set; }

        /// <summary>
        ///     Is the user's answer correct?
        /// </summary>
        public abstract bool IsCorrect { get; }

        /// <summary>
        ///     All questions must have at least basic text.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        public Question(string question)
        {
            QuestionText = question;
        }

        /// <summary>
        ///     Ask the question.
        /// </summary>
        public void Ask()
        {
            Console.WriteLine($"{QuestionText} {Instructions}");
        }

        /// <summary>
        ///     Collect an answer from the user.
        /// </summary>
        public abstract void Answer();
    }
}
