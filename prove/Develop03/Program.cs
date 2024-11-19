using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiation
        Scripture scripture = new Scripture();
        string check;

        //Looping until user inputs 'quit' or scripture is completely hidden
        do 
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            check = Console.ReadLine();
            if (check != "quit")
            {
                scripture.HideWords();
            }
        }while (check != "quit" && scripture.IsCompletelyHidden());

        //Final Display to show completely hidden scripture
        Console.Clear();
        scripture.Display();
    }
}