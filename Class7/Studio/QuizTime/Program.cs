namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var quiz = new Quiz();
            quiz.Start();
            quiz.Grade();
        }
    }
}
