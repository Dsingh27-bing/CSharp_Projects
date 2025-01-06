namespace Arrays_Strings;

// Write a method that calculates all prime numbers in given range and returns them as array
// of integers

public class PrimeOrNot
{
    public void FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        
        for (int num = startNum; num <= endNum; num++)
        {
            bool isPrime = true;
            if (num <= 1) 
                isPrime = false;
            
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            
            if (isPrime)
            {
                primes.Add(num);
            }
        }

        Console.WriteLine("Prime numbers in the range are :");
        foreach (int number in primes)
        {
            Console.Write(number+" ");
            
        }
        
    }
}