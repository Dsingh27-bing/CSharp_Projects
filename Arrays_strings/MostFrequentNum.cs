namespace Arrays_Strings;
using System.Collections;
// Write a program that finds the most frequent number in a given sequence of numbers. In
// case of multiple numbers with the same maximal frequency, print the leftmost of them

public class MostFrequentNum
{
    public void FrequentNum(int[] array)
    {
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        foreach (int i in array)
        {
            if (hashmap.ContainsKey(i))
            {
                hashmap[i] ++;

            }
            else
            {
                hashmap[i] = 1;
            }
            
        }
        
        int maxFrequency = 0;
        int mostFrequentNum = 0;
        
        foreach (var kvp in hashmap)
        {
            if (kvp.Value > maxFrequency)
            {
                maxFrequency = kvp.Value;
                mostFrequentNum = kvp.Key;
            }
        }
        
        Console.WriteLine("Most Frequent Number is : " + mostFrequentNum);
        
    }
    
}