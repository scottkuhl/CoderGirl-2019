using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizTime
{
    /// <summary>
    ///     A question with a fixed set of possible answers, of which any number may be chosen; there is one correct combination of choices.
    /// </summary>
    public class Checkbox : QuestionList
    {
        /// <summary>
        ///     Correct answers.
        /// </summary>
        public List<string> ActualAnswers { get; private set; } = new List<string>();

        /// <summary>
        ///     User's answers.
        /// </summary>
        public List<string> UserAnswers { get; set; } = new List<string>();

        /// <summary>
        ///     Checkboxes must have questions and answers.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="possibleAnswers">Possible answers.</param>
        /// <param name="answers">Correct answers.</param>
        public Checkbox(string question, List<string> possibleAnswers, List<string> answers) : base(question, possibleAnswers)
        {
            Instructions = " (Choose all correct answers separated by commas.)";
            ActualAnswers = answers;
        }

        /// <summary>
        ///     Does the user answer match the correct answers?
        /// </summary>
        public override bool IsCorrect
        {
            get
            {
                // Clean up before the matching by converting to lower case with no leading or trailing spaces.
                var answers = ActualAnswers.ConvertAll(a => a.ToLower().Trim());
                var userAnswers = UserAnswers.ConvertAll(a => a.ToLower().Trim());

                // Compare the results in each list to the other.
                var answersNotInUserAnswers = answers.Except(userAnswers).ToList();
                var userAnswersNotInAnswers = userAnswers.Except(answers).ToList();

                // Both lists must be empty to be considered a perfect match.
                return !answersNotInUserAnswers.Any() && !userAnswersNotInAnswers.Any();
            }
        }

        /// <summary>
        ///     Collect an answer from the user.
        /// </summary>
        public override void Answer()
        {
            foreach (var answer in PossibleAnswers)
            {
                Console.WriteLine(answer);
            }

            UserAnswers = Console.ReadLine().Split(',').ToList();
        }
    }
}
