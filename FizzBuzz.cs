namespace UnderstandingTypes;

public class FizzBuzz
{
    public void Fizz_Buzz(int number)
    {
        for (int i = number; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("fizzbuzz ");
            }
            else if (i%3 == 0)
            {
                Console.Write("fizz ");
            }
            else if (i%5 == 0)
            {
                Console.Write("buzz ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}