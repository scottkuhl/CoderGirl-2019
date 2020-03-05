using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private static int nextCourseId = 1;

        public string Name { get; set; }

        public int CourseId { get; private set; }

        public int NumberOfCredits { get; set; }

        public List<Student> Students { get; private set; } = new List<Student>();

        public Course(string name, int numberOfCredits)
        {
            CourseId = nextCourseId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
        }

        public Course(string name)
            : this(name, 0) { }
    }
}
