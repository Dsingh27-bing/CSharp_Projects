namespace OOP2;

public class Student: Person, IStudentService
{
    private readonly List<Course> _enrolledCourses = new List<Course>();
    private readonly Dictionary<Course, char> _grades = new Dictionary<Course, char>();
    
    public Student(string name, DateTime birthDate, decimal baseSalary) : base(name, birthDate, baseSalary)
    {
        
    }
    
    public void EnrollInCourse(Course course)
    {
        _enrolledCourses.Add(course);
        course.AddStudent(this);
    }
    
    public double CalculateGPA()
    {
        if (_grades.Count == 0) return 0;

        double totalPoints = 0;
        int totalCourses = 0;

        foreach (var grade in _grades.Values)
        {
            totalPoints += GradeToPoint(grade);
            totalCourses++;
        }

        return totalPoints / totalCourses;
    }
    
    private double GradeToPoint(char grade)
    {
        return grade switch
        {
            'A' => 4.0,
            'B' => 3.0,
            'C' => 2.0,
            'D' => 1.0,
            'F' => 0.0,
            _ => throw new ArgumentException("Invalid grade")
        };
    }

    public void AssignGrade(Course course, char grade)
    {
        if (!_enrolledCourses.Contains(course))
            throw new ArgumentException("Student is not enrolled in the course");
        _grades[course] = grade;
    }
    
}