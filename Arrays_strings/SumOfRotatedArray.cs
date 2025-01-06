using System.Runtime.Intrinsics.X86;

namespace Arrays_Strings;

// Write a program to read an array of n integers (space separated on a single line) and an
// integer k, rotate the array right k times and sum the obtained arrays after each rotation as
//     shown below.
//     After r rotations the element at position I goes to position (I + r) % n.
//     The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
//     Input     Output                Comments
//     3 2 4 -1   3 2 5 6              rotated1[] = -1 3 2 4
//       2                             rotated2[] = 4 -1 3 2
//                                          sum[] = 3 2 5 6
    
public class SumOfRotatedArray
{
    public void RotateArraySum(int[] inputArray, int rotations)
    {
        int n = inputArray.Length;
        int index = 0;      
        int[] sumArray = new int[n];
        int[] rotatedArray = new int[n];
        
        Array.Copy(inputArray, rotatedArray, n);

        for (int r = 1; r <= rotations; r++)
        {
            int[] tempArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                index = (i + 1) % n;
                tempArray[index] = rotatedArray[i];

            }
            Array.Copy(tempArray, rotatedArray, n);
            for (int i = 0; i < n; i++)
            {
                sumArray[i] += rotatedArray[i];
            }
            
        }
        Console.WriteLine("Final Sum Array:");
        Console.WriteLine(string.Join(" ", sumArray));
    }
}