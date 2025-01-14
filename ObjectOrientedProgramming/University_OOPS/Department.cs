namespace OOP2;

public class Department: IDepartmentService_
{
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Instructor Head { get; private set; }
    private readonly List<Course> _courses = new List<Course>();

    public Department(string name, decimal budget, DateTime startDate, DateTime endDate)
    {
        Name = name;
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void AssignHead(Instructor instructor)
    {
        Head = instructor;
        instructor.SetDepartment(this, true);
    }

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return _courses;
    }
}