using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizTime
{
    /// <summary>
    ///     A very basic movie quiz.
    /// </summary>
    public class Quiz
    {
        /// <summary>
        ///     List of questions.
        /// </summary>
        public List<Question> Questions { get; set; } = new List<Question>();

        /// <summary>
        ///     Populate the question list on creation.
        /// </summary>
        public Quiz()
        {
            Questions.Add(new TrueFalse("Is Star Trek better then Star Wars?", true));

            Questions.Add(new MultipleChoice("Who was not in Raiders of the Lost Ark?", new List<string>
            {
                "Harrison Ford",
                "Karen Allen",
                "Jonathan Rhys Meyers",
                "Paul Freeman"
            }, "Jonathan Rhys Meyers"));

            Questions.Add(new Checkbox("Who was in Ghostbusters?", new List<string>
            {
                "Bill Murray",
                "Rick Ramis",
                "Dan Aykroyd",
                "Sigourney Weaver",
                "Harold Moranis"
            }, new List<string>
            {
                "Bill Murray",
                "Dan Aykroyd",
                "Sigourney Weaver"
            }));

            Questions.Add(new ShortAnswer("Who played Doc Brown in Back to the Future?", "Christopher Lloyd"));

            Questions.Add(new LinearScale("What year was the film Firestarter release?", 1980, 1990, 1984));

            Questions.Add(new ParagraphAnswer("What is the opening line to Plan 9 From Outer Space?", "Greetings, my friends! We are all interested in the future, for that is where you and I are going to spend the rest of our lives."));
        }

        /// <summary>
        ///     Start the quiz.
        /// </summary>
        public void Start()
        {
            foreach (var question in Questions)
            {
                question.Ask();
                question.Answer();
            }
        }

        /// <summary>
        ///     Grade the quiz.
        /// </summary>
        public void Grade()
        {
            var possibleTotal = Questions.Count;
            var correctAnswers = Questions.Count(x => x.IsCorrect);

            Console.WriteLine($"You got {correctAnswers} out of {possibleTotal} correct.");
        }
    }
}
