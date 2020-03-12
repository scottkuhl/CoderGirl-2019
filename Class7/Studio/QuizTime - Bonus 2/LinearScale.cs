using System;

namespace QuizTime
{
    /// <summary>
    ///     A question that allows the user to provide a numeric response within an integer scale, which may vary from question to question. For instance, it could be 1-3 for one linear scale question, and 1-5 for another.
    /// </summary>
    public class LinearScale : Question
    {
        /// <summary>
        ///     Correct answer.
        /// </summary>
        public int ActualAnswer { get; private set; }


        /// <summary>
        ///     User's answer.
        /// </summary>
        public int UserAnswer { get; set; }

        /// <summary>
        ///     Minimum value.
        /// </summary>
        public int MinValue { get; private set; }

        /// <summary>
        ///     Maximum value.
        /// </summary>
        public int MaxValue { get; private set; }

        /// <summary>
        ///     Linear scale must have a question, range answer.
        /// </summary>
        /// <param name="question">Question to ask.</param>
        /// <param name="minValue">Minimum value.</param>
        /// <param name="maxValue">Maximum value.</param>
        /// <param name="answer">Correct answers.</param>
        public LinearScale(string question, int minValue, int maxValue, int answer) : base(question)
        {
            Instructions = $"(Choose an integer value between {minValue} and {maxValue})";
            MinValue = minValue;
            MaxValue = maxValue;
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
            if (int.TryParse(Console.ReadLine(), out int intAnswer))
            {
                UserAnswer = intAnswer;
            }
        }
    }
}
