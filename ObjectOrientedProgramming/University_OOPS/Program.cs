namespace OOP2;

class Program
{
    static void Main(string[] args)
    {
        // Department
        Department csDepartment = new Department("Computer Science", 1000000, DateTime.Now, DateTime.Now.AddYears(1));

        // Instructor
        Instructor instructor = new Instructor("Dr. Smith", new DateTime(1980, 5, 12), 50000);
        csDepartment.AssignHead(instructor);

        // Student
        Student student = new Student("Alice", new DateTime(2000, 8, 25), 0);

        //Course
        Course programmingCourse = new Course("Programming 101");
        csDepartment.AddCourse(programmingCourse);

        // Enroll Student in Course example
        student.EnrollInCourse(programmingCourse);

        // Assign Grade example
        student.AssignGrade(programmingCourse, 'A');

        // Calculate GPA example
        Console.WriteLine($"Student GPA: {student.CalculateGPA()}");

        // Instructor experience example
        Console.WriteLine($"Instructor Experience: {instructor.CalculateExperience(new DateTime(2010, 9, 1))} years");
        
        // Bonus Salary example
        Console.WriteLine($"Instructor's Salary with Bonus: {instructor.CalculateBonusSalary(50000, 14)}");
    }
}