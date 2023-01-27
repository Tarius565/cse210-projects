using System;

public class Menu
{
    public int Run()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
        Console.Write("What would you like to do? ");
        int option = int.Parse(Console.ReadLine());
        return option;
    }

}