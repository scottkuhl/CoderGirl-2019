using System;

namespace QuizTime
{
    /// <summary>
    ///     A text answer question type that includes validation behavior.
    /// </summary>
    public class TextAnswer : Question
    {
        /// <summary>
        ///     Correct answer.
        /// </summary>
        public string ActualAnswer { get; private set; }

        /// <summary>
        ///     Max length of the user's answer.
        /// </summary>
        public int MaxLength { get; private set; }

        /// <summary>
        ///     User's answers.
        /// </summary>
        public string UserAnswer { get; set; }

        /// <summary>
        ///     Text answer must have a question, max length and answer.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="maxLength">Maximum length of the answer.</param>
        /// <param name="answer">Correct answers.</param>
        public TextAnswer(string question, int maxLength, string answer) : base(question)
        {
            Instructions = $"(Your answer must be {maxLength} characters or less.)";
            MaxLength = maxLength;
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

            while (UserAnswer.Trim().Length > MaxLength)
            {
                Console.WriteLine("Your answer is too long.");
                UserAnswer = Console.ReadLine();
            }
        }
    }
}
