namespace OOP2;

public class Course: ICourseService
{
    public string cName { get; set; }
    private readonly List<Student> _enrolledStudents = new List<Student>();

    public Course(string name)
    {
        cName = name;
    }

    public void AddStudent(Student student)
    {
        _enrolledStudents.Add(student);
    }

    public List<Student> GetEnrolledStudents()
    {
        return _enrolledStudents;
    }
}