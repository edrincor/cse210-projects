using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string action;
        do 
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.WriteLine("What would you like to do? ");
            action = Console.ReadLine();

            if (action == "1")
            {
                journal.AddEntry();
            }
            else if (action == "2")
            {
                journal.Display();
            }
            else if (action == "3")
            {
                journal.Load();
            }
            else if (action == "4")
            {
                journal.Save();
            }
        } while(action != "5");
    }
}