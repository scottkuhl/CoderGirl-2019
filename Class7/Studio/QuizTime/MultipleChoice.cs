using System;
using System.Collections.Generic;

namespace QuizTime
{
    /// <summary>
    ///     A question with a fixed set of possible answers, of which only one may be chosen and only one answer is correct.
    /// </summary>
    public class MultipleChoice : QuestionList
    {
        /// <summary>
        ///     Correct answers.
        /// </summary>
        public string ActualAnswer { get; private set; }

        /// <summary>
        ///     User's answers.
        /// </summary>
        public string UserAnswer { get; set; }

        /// <summary>
        ///     Multiple choices must have questions and answers.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="possibleAnswers">Possible answers.</param>
        /// <param name="answers">Correct answers.</param>
        public MultipleChoice(string question, List<string> possibleAnswers, string answer) : base(question, possibleAnswers)
        {
            Instructions = " (Choose one correct answer.)";
            ActualAnswer = answer;
        }

        /// <summary>
        ///     Does the user answer match the correct answers?
        /// </summary>
        public override bool IsCorrect => ActualAnswer.ToLower() == UserAnswer.ToLower();

        /// <summary>
        ///     Collect an answer from the user.
        /// </summary>
        public override void Answer()
        {
            foreach (var answer in PossibleAnswers)
            {
                Console.WriteLine(answer);
            }

            UserAnswer = Console.ReadLine();
        }
    }
}
