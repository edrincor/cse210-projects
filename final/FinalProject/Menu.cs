public class Menu
{
    //Menu used when starting the program
    public void StartMenu()
    {
        Console.WriteLine("Welcome to Perilous Pages");
        Console.WriteLine("Would you like to enter the dungeon? [Y/N]");
        if (Console.ReadLine().ToLower() == "y")
        {
            Console.WriteLine("Welcome to the dungeon...\n \n");
        }
        else
        {
            Console.WriteLine("Too bad.\n \n");
        }
    }

    //Menu used when player chooses their character
    public void CharacterMenu()
    {
        Console.WriteLine("Choose your class. [1, 2, or 3]");
        Console.WriteLine("1) Fighter: A simple warrior, the Fighter starts with a sword and shield.");
        Console.WriteLine("2) Sorcerer: By harnessing arcane power the Sorcerer can hit multiple enemies at once, but he has weaker armor.");
        Console.WriteLine("3) Rogue: Relying on her speed, the Rogue has an additional action and a critical hit chance.");
    }

    //Menu used during player turn in combat
    public void CombatMenu()
    {
        Console.WriteLine("Combat Actions.");
        Console.WriteLine("1) Attack an enemy!");
        Console.WriteLine("2) Use a potion.");
        Console.WriteLine("3) Pass your turn.");
    }

    //Menu used before generating new room
    public int RoomEndMenu()
    {
        Console.WriteLine("Room Actions.");
        Console.WriteLine("1) Use an item.");
        Console.WriteLine("2) Equip an item");
        Console.WriteLine("3) Pick up loot");
        Console.WriteLine("4) Continue onwards");
        
        int choice = Int32.Parse(Console.ReadLine());
        return choice;
    }
}