namespace OOP2;

public interface IInstructorService: IPersonService
{
    void SetDepartment(Department department, bool isHead = false);
    int CalculateExperience(DateTime joinDate);
    decimal CalculateBonusSalary(decimal baseSalary, int experienceYears);
}