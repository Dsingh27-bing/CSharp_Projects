namespace UnderstandingTypes;

public class PatternPrint
{
    public void Pattern(int n)
    {

        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}