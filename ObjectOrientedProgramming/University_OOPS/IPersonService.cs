namespace OOP2;

public interface IPersonService
{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary(decimal baseSalary);
    void AddAddress(string address);
    List<string> GetAddress();
}