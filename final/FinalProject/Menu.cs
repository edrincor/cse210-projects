public class Menu
{
    //Menu used when starting the program
    public bool StartMenu()
    {
        Console.WriteLine("Welcome to [Placeholder]");
        Console.WriteLine("Would you like to enter the dungeon? [Y/N]");
        if (Console.ReadLine().ToLower() == "y")
        {
            Console.WriteLine("Welcome to the Dungeon...\n \n");
            return true;
        }
        else
        {
            return false;
        }
    }

    //Menu used when player chooses their character
    public int CharacterMenu()
    {
        Console.WriteLine("Choose your character. [1, 2, 3, or 4]");
        Console.WriteLine("1) Fighter: A simple warrior, the Fighter starts with a sword and shield.");
        Console.WriteLine("2) Sorcerer: Harnessing arcane power the Sorcerer can hit multiple enemies at once, but he has weaker armor.");
        Console.WriteLine("3) Rogue: Relying on her speed, the Rogue has additional actions and a critical hit chance.");
        Console.WriteLine("4) Cleric: Relying on his faith, the Cleric has heavy armor and the unique ability to heal.");

        int choice = Int32.Parse(Console.ReadLine());
        return choice;
    }

    //Menu used during player turn in combat
    public int CombatMenu()
    {
        Console.WriteLine("Combat Actions.");
        Console.WriteLine("1) Attack an enemy!");
        Console.WriteLine("2) Use an item.");
        Console.WriteLine("3) Pass your turn.");

        int choice = Int32.Parse(Console.ReadLine());
        return choice;
    }

    //Menu used before generating new room
    public int RoomEndMenu()
    {
        Console.WriteLine("Room Actions.");
        Console.WriteLine("1) Use an item.");
        Console.WriteLine("2) Equip an item");
        Console.WriteLine("3) Continue onwards");
        
        int choice = Int32.Parse(Console.ReadLine());
        return choice;
    }
}