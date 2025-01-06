namespace Arrays_Strings;

public class ToDoList
{
    private List<String> myList = new List<string>();
    public void ToDO(string input)
    {
        

        if (input.StartsWith("+"))
        {
            myList.Add(input.Substring(1).Trim());
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            
        }
        else if (input.StartsWith("-"))
        {
            if (myList.Count > 0)
            {
                myList.Remove(input.Substring(1).Trim());
                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("List is empty");
                
            }
            
        }
        else if (input == "__")
        {
            myList.Clear();
            Console.WriteLine("List Cleared");
        }
        else if (input == "q")
        {
            Console.WriteLine("Exiting...");
            return;
        }
        else
        {
            Console.WriteLine("Invalid Command");
        }
    }
}