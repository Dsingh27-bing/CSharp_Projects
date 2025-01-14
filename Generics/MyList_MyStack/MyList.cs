namespace Generics;

// 1. void Add (T element)
// 2. T Remove (int index)
// 3. bool Contains (T element)
// 4. void Clear ()
// 5. void InsertAt (T element, int index)
// 6. void DeleteAt (int index)
// 7. T Find (int index)

public class MyList<T>
{
    private List<T> list = new List<T>();

    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        T item = list[index]; 
        list.RemoveAt(index);
        Print();
        return item;
    }

    public bool Contains(T element)
    {
        if (list.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Clear()
    {
        list.Clear();
        Console.WriteLine("List :");
        Print();
    }

    public void InsertAt(T element, int index)
    {
        list.Insert(index, element);
        Print();
    }

    public void DeleteAt(int index)
    {
        list.RemoveAt(index);
        Print();
    }

    public T Find(int index)
    {
        return list[index];
    }

    public void Print()
    {
        foreach (var item in list)
        {
            Console.Write(item+" ");
        }
        
    }
}