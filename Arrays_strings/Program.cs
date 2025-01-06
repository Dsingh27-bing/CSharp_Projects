namespace Arrays_Strings;
    
class Program
{
    static void Main(string[] args)
    {
        CopyArray ca = new CopyArray();
        ca.CopyOfArray();
        ClearScreen();
        
        ToDoList td = new ToDoList();
        string inputUser = "";
        while (inputUser != "q")
        {
            Console.WriteLine("Enter command (+ item, - item, __ to clear, or q to exit):");
            inputUser = Console.ReadLine();
            td.ToDO(inputUser);
        }
        ClearScreen();

        PrimeOrNot p = new PrimeOrNot();
        Console.WriteLine("Enter start number:");
        int startNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end number:");
        int endNum = Convert.ToInt32(Console.ReadLine());
        p.FindPrimesInRange(startNum, endNum);
        ClearScreen();
        
        Console.WriteLine("Enter the array elements (space-separated):");
        int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine("Enter the number of rotations:");
        int rotations = Convert.ToInt32(Console.ReadLine());
        SumOfRotatedArray obj = new SumOfRotatedArray();
        obj.RotateArraySum(inputArray, rotations);
        ClearScreen();
        
        Console.WriteLine("Enter the array elements (space-separated):");
        LongestSequence ls = new LongestSequence();
        string inputs = Console.ReadLine();
        int[] arrays = Array.ConvertAll(inputs.Split(' '), int.Parse);
        ls.FindLongestSequence(arrays);
        ClearScreen();
        
         MostFrequentNum f= new MostFrequentNum();
         Console.WriteLine("Enter the array elements (space-separated):");
         string input = Console.ReadLine();
         int[] array = Array.ConvertAll(input.Split(' '), int.Parse);
         f.FrequentNum(array);
         ClearScreen();
         
         ReverseString rs = new ReverseString();
         Console.WriteLine("Enter string to reverse");
         string user_input = Console.ReadLine();
         Console.WriteLine( "1) using array of string 2) using for loop , \nEnter choice as 1 or 2:");
         string choice = Console.ReadLine();
         rs.Reverse(user_input, choice);
         ClearScreen();
         
         ReverseWords rw = new ReverseWords();
         Console.WriteLine("Enter a sentence to reverse the words:");
         string inputSentence = Console.ReadLine();
         string reversedSentence = rw.Reverse(inputSentence);
         Console.WriteLine("Original sentence:"+ inputSentence);
         Console.WriteLine("Reversed sentence:"+ reversedSentence);
         ClearScreen();
        
        PalindromeWords pw = new PalindromeWords();
        Console.WriteLine("Enter a sentence to find palindromes:");
        string words = Console.ReadLine();
        pw.Palindromes(words);
        ClearScreen();

        UrlParsing up = new UrlParsing();
        Console.WriteLine("Enter a URL to parse:");
        string input_user = Console.ReadLine();
        up.Parsing(input_user);
        ClearScreen();

    }

    public static void ClearScreen()
    {
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
    }
}