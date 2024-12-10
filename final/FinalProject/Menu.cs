public class Menu
{
    public bool StartMenu()
    {
        Console.WriteLine("Welcome to [Placeholder]");
        Console.WriteLine("Would you like to enter the dungeon? [Y/N]");
        if (Console.ReadLine().ToLower() == "y")
        {
            Console.WriteLine("Welcome to the Dungeon...");
            return true;
        }
        else
        {
            return false;
        }
    }

    public int CharacterMenu()
    {
        Console.WriteLine("Choose your character");
        Console.WriteLine("1) Fighter: A simple warrior, the Fighter starts with a sword and shield.");
        Console.WriteLine("2) Sorcerer: Harnessing arcane power, the Sorcerer has weaker armor, but he can hit multiple enemies at once.");
        Console.WriteLine("3) Rogue: Relying on her speed, the Rogue has additional actions and a critical hit chance.");
        Console.WriteLine("4) Cleric: Relying on his faith, the Cleric has heavy armor and the unique ability to heal.");

        int choice = Int32.Parse(Console.ReadLine());
        Console.WriteLine("What is your characters name?");
        return choice;
    }
}