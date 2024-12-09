using System;

public class Menu()
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        return Int32.Parse(Console.ReadLine());
    }
    public void DisplaySubMenu()
    {
        
    }
}