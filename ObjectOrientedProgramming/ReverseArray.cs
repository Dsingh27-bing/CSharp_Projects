namespace ObjectOrientedProgramming;

// Let’s make a program that uses methods to accomplish a task. Let’s take an array and
// reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
// become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
// To accomplish this, you’ll create three methods: one to create the array, one to reverse the
// array, and one to print the array at the end.
// Your Mainmethod will look something like this:
// static void Main(string[] args) {
//     int[] numbers = GenerateNumbers();
//     Reverse(numbers);
//     PrintNumbers(numbers);
// }
// The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
//     change the method to allow the desired length to be passed in, instead of just always
// being 10.)
// The PrintNumbersmethod should use a foror foreachloop to print out each item in the
// array. The Reversemethod will be the hardest. Give it a try and see what you can make
// happen. If you get
//     stuck, here’s a couple of hints:
// Hint #1:To swap two values, you will need to place the value of one variable in a temporary
// location to make the swap:

public class ReverseArray
{
    private int[] numbers;
    public void GenerateNumbers(int length)
    {
        numbers = new int[length];
        Random rnd = new Random();
        for ( int i=0; i<length; i++)
        {
            numbers[i] = rnd.Next(1,101);
        }
        
    }
    
    public void PrintNumbers()
    {
        Console.WriteLine("Array: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
    
    public void Reverse()
    {
        int temp;
        int length = numbers.Length;
        for (int i = 0; i < length / 2; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[length - i - 1];
            numbers[length - i - 1] = temp;
        }
        Console.Write("\nReversed ");
    }
    
}