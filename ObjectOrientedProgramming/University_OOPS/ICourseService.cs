namespace OOP2;

public interface ICourseService
{
    void AddStudent(Student student);
    List<Student> GetEnrolledStudents();
}