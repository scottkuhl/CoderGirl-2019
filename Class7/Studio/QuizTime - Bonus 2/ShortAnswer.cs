namespace QuizTime
{
    /// <summary>
    ///     A short answer question type that includes validation behavior to only allow the user to enter text up to 80 characters.
    /// </summary>
    public class ShortAnswer : TextAnswer
    {
        /// <summary>
        ///     Short answer must have a question and answer.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="answer">Correct answers.</param>
        public ShortAnswer(string question, string answer) : base(question, 80, answer)
        {
        }
    }
}
