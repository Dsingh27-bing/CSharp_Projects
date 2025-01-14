namespace OOP2;

public interface IDepartmentService_
{
    void AssignHead(Instructor instructor);
    void AddCourse(Course course);
    List<Course> GetCourses();
}