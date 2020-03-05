using System.Collections.Generic;
using System.Linq;

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

        public void AddGrade(Grade grade, Student student)
        {
            var studentRef = Students.FirstOrDefault(x => x.Equals(student));
            studentRef?.AddGrade(grade, NumberOfCredits);
        }

        public GradeLevel.Levels GetAverageGradeLevel()
        {
            var average = Students.Sum(x => x.NumberOfCredits) / Students.Count();
            return GradeLevel.GetLevel(average);
        }

        public override bool Equals(object obj)
        {
            var courseObj = obj as Course;
            return CourseId == courseObj.CourseId;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ")";
        }

        public override int GetHashCode()
        {
            return CourseId;
        }
    }
}
