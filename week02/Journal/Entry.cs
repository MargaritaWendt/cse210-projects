using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public void Display()
    {
            
    }
        static void Main(string[] args)
    {

        Console.WriteLine("Please select one of the following:");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        string opcion = Console.ReadLine();
    }
}