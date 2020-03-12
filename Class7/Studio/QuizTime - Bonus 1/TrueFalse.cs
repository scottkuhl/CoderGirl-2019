using System;

namespace QuizTime
{
    /// <summary>
    ///     A question that has a true/false answer.
    /// </summary>
    public class TrueFalse : Question
    {
        /// <summary>
        ///     Correct answer.
        /// </summary>
        public bool ActualAnswer { get; private set; }


        /// <summary>
        ///     User's answer.
        /// </summary>
        public bool UserAnswer { get; set; }

        /// <summary>
        ///     True/False must have a question and answer.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="answer">Correct answers.</param>
        public TrueFalse(string question, bool answer) : base(question)
        {
            Instructions = "(Choose True or False.)";
            ActualAnswer = answer;
        }

        /// <summary>
        ///     Does the user answer match the correct answers?
        /// </summary>
        public override bool IsCorrect => ActualAnswer == UserAnswer;

        /// <summary>
        ///     Collect an answer from the user.
        /// </summary>
        public override void Answer()
        {
            if (bool.TryParse(Console.ReadLine(), out bool boolAnswer))
            {
                UserAnswer = boolAnswer;
            }
        }
    }
}
