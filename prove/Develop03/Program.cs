using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string loop;

        do 
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            loop = Console.ReadLine();
            if (loop == "")
            {
                scripture.HideWords();
            }
        
        }while (loop != "quit" && scripture.IsCompletelyHidden() == false);

    }
}