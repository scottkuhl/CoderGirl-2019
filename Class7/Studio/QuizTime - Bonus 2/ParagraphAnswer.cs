namespace QuizTime
{
    /// <summary>
    ///     A long answer question type that includes validation behavior to only allow the user to enter text up to 500 characters.
    /// </summary>
    public class ParagraphAnswer : TextAnswer
    {
        /// <summary>
        ///     Paragraph answer must have a question and answer.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="answer">Correct answers.</param>
        public ParagraphAnswer(string question, string answer) : base(question, 500, answer)
        {
        }
    }
}
