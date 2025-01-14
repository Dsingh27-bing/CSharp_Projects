using System.ComponentModel;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        //example with int inputs
        Console.WriteLine("Enter items to be inserted in the stack:");
        string[] input = (Console.ReadLine()).Split(" ");
        
        
        MyStack<int> item = new MyStack<int>();
        foreach (var i in input)
        {
            item.Push(Convert.ToInt32(i));
        }
        Console.WriteLine("Number of Items in the stack:" + item.Count());
        Console.WriteLine("Items in the stack(POP):");
        while (item.Count() > 0)
        {
            Console.Write(item.Pop()+" ");
        }
        
        // example with string inputs
        Console.WriteLine("\n\nEnter items to be inserted in the stack:");
        string[] input2 = (Console.ReadLine()).Split(" ");
        MyStack<string> item2 = new MyStack<string>();
        foreach (var j in input2)
        {
            item2.Push(j);
        }
        Console.WriteLine("Number of Items in the stack:" + item2.Count());
        Console.WriteLine("Items in the stack(POP):");
        while (item2.Count() > 0)
        {
            Console.Write(item2.Pop()+" ");
        }
        
        ClearScreen();
        
        
        
        Console.WriteLine("Enter items to be inserted in the list:");
        string[] input3 = (Console.ReadLine()).Split(" ");
        MyList<string> item3 = new MyList<string>();
        foreach (var k in input3)
        {
            item3.Add(k);
        }
        item3.Print();
        Console.WriteLine("\nIndex(starts from 0) of the item to be removed:");
        int index = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nItem removed from the list:" + item3.Remove(index));
        Console.WriteLine("\nCheck if the item is present in the list:");
        string check = Console.ReadLine();
        if (item3.Contains(check))
        {
            Console.WriteLine("\nItem is present in the list");
        }
        else
        {
            Console.WriteLine("\nItem is not present in the list");
        }
        Console.WriteLine("\nInsert an item at a specific index enter item and index with space between them:");
        string[] insert = (Console.ReadLine()).Split(" ");
        item3.InsertAt(insert[0], Convert.ToInt32(insert[1]));
        Console.WriteLine("\nDelete an item at a specific index enter index:");
        item3.DeleteAt(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("\nFind an item at a specific index enter index:");
        Console.WriteLine("\nItem at the index is:" + item3.Find(Convert.ToInt32(Console.ReadLine())));
        Console.WriteLine("\nClearing the list now");
        item3.Clear();
        ClearScreen();
        
        
        
    }
    
    public static void ClearScreen()
    {
        Thread.Sleep(2000);
        Console.Clear();
    }
}