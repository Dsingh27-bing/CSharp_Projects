namespace OOP2;

public class Instructor:Person, IInstructorService
{
    public Department Department { get; private set; }
    public bool IsHeadOfDepartment { get; private set; }

    public Instructor(string name, DateTime birthDate, decimal salary)
        : base(name, birthDate, salary) { }

    public void SetDepartment(Department department, bool isHead = false)
    {
        Department = department;
        IsHeadOfDepartment = isHead;
    }

    public int CalculateExperience(DateTime joinDate)
    {
        DateTime today = DateTime.Now;
        int experience = today.Year - joinDate.Year;
        if (today < joinDate.AddYears(experience)) experience--;
        return experience;
    }

    public decimal CalculateBonusSalary(decimal baseSalary, int experienceYears)
    {
        return baseSalary + (experienceYears * 1000); // Example bonus calculation not provided in question
    }
}