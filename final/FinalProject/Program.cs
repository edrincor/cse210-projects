using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Dungeon dungeon = new Dungeon();
        Menu menu = new Menu();
        Player player;
        Inventory inventory = new Inventory();
        Fight combat = new Fight();
        int choice;
        int roomTotal = 8;

        menu.StartMenu();
        menu.CharacterMenu();
        choice = Int32.Parse(Console.ReadLine());
        player = dungeon.PlayerClass(choice);

        //Dungeon loop
        for (int i = 0; i < roomTotal; i++)
        {
            dungeon.GenerateRoom(i);
            while (dungeon.GetEnemies().Count > 0)
            {
                menu.CombatMenu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Which enemy would you like to attack?");
                        
                }
            }
        }
    }
}