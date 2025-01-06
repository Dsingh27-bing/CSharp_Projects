namespace Arrays_Strings;
// Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
// and prints them on the console on a single line, separated by comma and space.Print all
// unique palindromes (no duplicates), sorted
//     Hi,exe? ABBA! Hog fully a string: ExE. Bob
//     a, ABBA, exe, ExE

public class PalindromeWords
{
    public void Palindromes(string sentence)
    {
        List<string> separators = new List<string> { " ", ",", ".", "!", "?", ";", ":", "-", "'", "\"", "(", ")" };
        HashSet<string> result = new HashSet<string>();
        
        string[] words = sentence.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        // Console.WriteLine(string.Join(" ",words));
        foreach (string word in words)
        {
            string reversedWord = new string(word.Reverse().ToArray());
            if (word.Equals(reversedWord))
            {
                result.Add(word);
            }
            
        }
        
        Console.WriteLine("Palindromes are:");
        foreach (string palindrome in result.OrderBy(p => p))
        {
            Console.Write(palindrome + ", ");
        }
        
    }
}