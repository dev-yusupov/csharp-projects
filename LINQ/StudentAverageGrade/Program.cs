using System.Globalization;

namespace StudentAverageGrade
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
    }

    public class StudentAverage
    {
        public string StudentName { get; set; }
        public double AverageGrade { get; set; }
    }


    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Grades = new List<int> { 85, 92, 88, 91 } },
            new Student { Name = "Bob", Grades = new List<int> { 78, 84, 80, 83 } },
            new Student { Name = "Charlie", Grades = new List<int> { 90, 85, 89, 92 } },
            new Student { Name = "David", Grades = new List<int> { 95, 97, 94, 96 } },
            new Student { Name = "Eve", Grades = new List<int> { 88, 91, 84, 87 } },
            new Student { Name = "Frank", Grades = new List<int> { 73, 75, 72, 74 } },
            new Student { Name = "Grace", Grades = new List<int> { 93, 89, 90, 92 } },
            new Student { Name = "Hannah", Grades = new List<int> { 86, 84, 88, 90 } },
            new Student { Name = "Ivan", Grades = new List<int> { 70, 72, 75, 74 } },
            new Student { Name = "Jack", Grades = new List<int> { 80, 85, 82, 84 } }
        };

        static void Main(string[] args)
        {
            if (students == null || !students.Any())
            {
                Console.WriteLine("No students available!");
                return;
            }

            var averageGrades = students
                .Select(student => new StudentAverage { StudentName = student.Name, AverageGrade = student.Grades.Average()})
                .OrderByDescending(student => student.AverageGrade)
                .Take(5);


            foreach (var student in averageGrades)
            {
                Console.WriteLine($"{student.StudentName}: {student.AverageGrade:F2}");
            }
               
        }
    }
}
