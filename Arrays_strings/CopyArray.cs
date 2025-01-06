namespace Arrays_Strings;


public class CopyArray
{
    public void CopyOfArray()
    {
        int[] array = {1,2,3,4,5,6,7,8,9,10};
        int[] arrayCopy= new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            arrayCopy[i]=(array[i]);
        }
        
        Console.WriteLine("Original Array :");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nCopy Array :");
        foreach (int itm in arrayCopy)
        {
            Console.Write(itm + " ");
        }
        
        
    }
}