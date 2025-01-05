namespace UnderstandingTypes;

public class BirthDateCalculator
{
    public void BirthDate(string birthDay)
    {
        DateTime birth = DateTime.Parse(birthDay);
        DateTime today = DateTime.Now;
        TimeSpan age = today - birth;
        int days = (int) age.TotalDays;
        Console.WriteLine($"You are {days} days old.");
        int daysToNextAnniversary = 10000 - (days % 10000);
        
        if (daysToNextAnniversary == 10000)
        {
            daysToNextAnniversary = 0; 
        }

        DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Your next 10,000 day anniversary is on {nextAnniversary.ToShortDateString()}");
    
    }
    
}
