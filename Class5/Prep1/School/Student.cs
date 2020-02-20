namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;

        public string Name { get; set; }

        // The ID has been changed to read only. IDs of classes should not change because they are a unique identifier.
        public int StudentId { get; private set; }

        public int NumberOfCredits { get; set; }

        public double Gpa { get; set; }

        public Student(string name, int numberOfCredits, double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name)
            : this(name, 0, 0) { }
    }

}