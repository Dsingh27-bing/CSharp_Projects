﻿namespace UnderstandingTypes;class Program{    static void Main(string[] args)    {        Datatypes dt = new Datatypes();        dt.Datatype_values();        ClearingConsole(); // clearing console in 2 seconds                Centuries centuries = new Centuries();        Console.WriteLine("Enter the number of centuries: ");        uint num = Convert.ToUInt32(Console.ReadLine());        centuries.CenturiesConvert(num);        ClearingConsole(); // clearing console in 2 seconds                FizzBuzz fb = new FizzBuzz();        Console.WriteLine("Enter the number to start the FizzBuzz game: ");        int num1 = Convert.ToInt32(Console.ReadLine());        fb.Fizz_Buzz(num1);        ClearingConsole(); // clearing console in 2 seconds        RandomNumberGuessing rg = new RandomNumberGuessing();        Console.WriteLine("Enter your guess: ");        int guessedNumber = int.Parse(Console.ReadLine());        rg.RandomGuess(guessedNumber);        ClearingConsole(); // clearing console in 2 seconds        PatternPrint p = new PatternPrint();        Console.WriteLine("Enter the number of rows for pattern print: ");        int rows = int.Parse(Console.ReadLine());        p.Pattern(rows);        ClearingConsole(); // clearing console in 2 seconds        BirthDateCalculator birth = new BirthDateCalculator();        Console.WriteLine("Enter the birth date (MM/DD/YYYY):  ");        string birthDay = Console.ReadLine();        birth.BirthDate(birthDay);        ClearingConsole();        TimeOfTheDay t = new TimeOfTheDay();        DateTime tm = DateTime.Now;        int hour = tm.Hour;        t.TimeOfDay(hour);        ClearingConsole();                Counting24 c = new Counting24();        c.Counting();        ClearingConsole();            }    public static void ClearingConsole()    {        System.Threading.Thread.Sleep(2000);        Console.Clear();    }}