namespace UnderstandingTypes;

public class Counting24
{
    public void Counting()
    {
        for (int outer = 1; outer <= 4; outer++)
        {
            
            for (int inner = 0; inner <= 24; inner += outer)
            {
               
                if (inner > 0)
                {
                    Console.Write(",");
                }
                Console.Write(inner);
            }

            Console.WriteLine();
        }
    }
}