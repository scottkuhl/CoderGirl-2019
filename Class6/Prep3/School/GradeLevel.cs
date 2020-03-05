namespace School
{
    public static class GradeLevel
    {
        public enum Levels { Freshman, Sophomore, Junior, Senior }

        public static Levels GetLevel(int numberOfCredits)
        {
            if (numberOfCredits <= 29) return Levels.Freshman;
            if (numberOfCredits <= 59) return Levels.Sophomore;
            if (numberOfCredits <= 89) return Levels.Junior;
            return Levels.Senior;
        }
    }
}
