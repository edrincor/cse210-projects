using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Dungeon dungeon = new Dungeon();
        Menu menu = new Menu();

        menu.StartMenu();
        int classChoice = menu.CharacterMenu();

    }
}