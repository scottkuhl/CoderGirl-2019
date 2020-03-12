using System;

namespace QuizTime
{
    /// <summary>
    ///     A short answer question type that includes validation behavior to only allow the user to enter text up to 80 characters.
    /// </summary>
    public class ShortAnswer : Question
    {
        /// <summary>
        ///     Correct answer.
        /// </summary>
        public string ActualAnswer { get; private set; }


        /// <summary>
        ///     User's answers.
        /// </summary>
        public string UserAnswer { get; set; }

        /// <summary>
        ///     Short answer must have a question and answer.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="answer">Correct answers.</param>
        public ShortAnswer(string question, string answer) : base(question)
        {
            Instructions = "(Your answer must be 80 characters or less.)";
            ActualAnswer = answer;
        }

        /// <summary>
        ///     Does the user answer match the correct answers?
        /// </summary>
        public override bool IsCorrect => ActualAnswer.ToLower().Trim() == UserAnswer.ToLower().Trim();

        /// <summary>
        ///     Collect an answer from the user.
        /// </summary>
        public override void Answer()
        {
            UserAnswer = Console.ReadLine();

            while (UserAnswer.Trim().Length > 80)
            {
                Console.WriteLine("Your answer is too long.");
                UserAnswer = Console.ReadLine();
            }
        }
    }
}
