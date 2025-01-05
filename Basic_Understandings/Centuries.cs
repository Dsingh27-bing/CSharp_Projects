namespace UnderstandingTypes;

public class Centuries
{
    public void CenturiesConvert(uint number)
    {
        uint years = number * 100;
        uint days = (uint)(years * 365.2425);
        uint hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong milliseconds = seconds * 1000;
        ulong microseconds = milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;
        
        Console.WriteLine($"{number} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}