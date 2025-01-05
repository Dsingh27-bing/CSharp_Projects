namespace UnderstandingTypes;


public class RandomNumberGuessing
{
    public void RandomGuess(int guess)
    {
        
        int correctNumber = new Random().Next(3) + 1;
        
        if (guess < 1 || guess > 3)
        {
            Console.WriteLine("Your guess is outside the range of numbers that are valid guesses");
        }
        else if (guess < correctNumber)
        {
            Console.WriteLine("Your guess is low");
        }
        else if (guess > correctNumber)
        {
            Console.WriteLine("Your guess is high");
        }
        else if (guess == correctNumber)
        {
            Console.WriteLine("You guessed the correct number");
        }
        
    }
}