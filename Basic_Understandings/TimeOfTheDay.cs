namespace UnderstandingTypes;

public class TimeOfTheDay
{
    public void TimeOfDay(int time)
    {
        if (time>=5 && time<12)
        {
            Console.WriteLine("Good Morning!");
        }
        if (time>=12 && time<16)
        {
            Console.WriteLine("Good Afternoon!");
        }
        if (time>=16 && time<21)
        {
            Console.WriteLine("Good Evening!");
        }

        if (time >= 21 || time < 5)
        {
            Console.WriteLine("Good Night!");
        }
    }
}