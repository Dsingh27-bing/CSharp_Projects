namespace OOP2;

public interface IStudentService: IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}