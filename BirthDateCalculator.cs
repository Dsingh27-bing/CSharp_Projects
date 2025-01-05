namespace UnderstandingTypes;

// Write a simple program that defines a variable representing a birth date and calculates
// how many days old the person with that birth date is currently.
//     For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
//     Note: once you figure out their age in days, you can calculate the days until the next
// anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .


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