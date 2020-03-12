using System.Collections.Generic;

namespace QuizTime
{
    /// <summary>
    ///     Base question type for a question that has more than one answer.
    /// </summary>
    public abstract class QuestionList : Question
    {
        /// <summary>
        ///     Possible correct answers. 
        /// </summary>
        public List<string> PossibleAnswers { get; private set; } = new List<string>();

        /// <summary>
        ///     List based questions must have question and possible answers.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="possibleAnswers">Possible correct answers.</param>
        public QuestionList(string question, List<string> possibleAnswers) : base(question)
        {
            PossibleAnswers = possibleAnswers;
        }
    }
}
