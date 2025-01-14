namespace OOP2;

public class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    protected  decimal Salary { get; set; }
    private readonly List<string> addresses = new List<string>();
    
    public Person(string name, DateTime dateOfBirth, decimal salary) //constructor
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        if (salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }
        else
        {
            Salary = salary;
        }
    }
    
    public int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Now;
        int age = today.Year - birthDate.Year;
        if (today < birthDate.AddYears(age)) age--;
        return age;
    }
    
    public decimal CalculateSalary(decimal baseSalary)
    {
        if (baseSalary < 0)
            throw new ArgumentException("Salary cannot be negative");
        return baseSalary;
    }
    
    public void AddAddress(string address) //function to add addresses
    {
        addresses.Add(address);
    }

    public List<string> GetAddress()
    {
        return addresses;
    }

}