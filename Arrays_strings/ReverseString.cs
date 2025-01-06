using System.Net;
using System.Text;

namespace Arrays_Strings;

// Write a program that reads a string from the console, reverses its letters and prints the
//     result back at the console.
//     Write in two ways
// Convert the string to char array, reverse it, then convert it to string again
// Print the letters of the string in back direction (from the last to the first) in a for-loop
    
public class ReverseString
{
    public void Reverse(string input, string choice)
    {

        switch (choice)
        {
            case "1":
                char[] charArray = input.ToArray();
                char[] reversedarray= charArray.Reverse().ToArray();
                Console.Write("The reversed array is: ");
                foreach (char c in reversedarray)
                {
                    Console.Write(c);
                }
                break;
            case "2":
                int n = input.Length;
                StringBuilder newString = new StringBuilder();
                for (int i = n - 1; i >= 0; i--)
                {
                    newString.Append(input[i]);
                }
                Console.Write("The reversed array is: "+ newString);
                break;
        }
    }
    
}