namespace Arrays_Strings;

public class LongestSequence
{
    public void FindLongestSequence(int[] array)
    {
        int maxLength = 0;
        int maxElement = 0;
        int currentLength = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1]) // Check if current element matches the previous
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength) // Update the longest sequence
                {
                    maxLength = currentLength;
                    maxElement = array[i - 1];
                }

                currentLength = 1; // Reset the current sequence length
            }
        }

        // Final check for the last sequence in the array
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxElement = array[array.Length - 1];
        }

        // Print the result
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(maxElement + " ");
        }

        Console.WriteLine();
    }

}