using System.Collections;
using System.Diagnostics;
using System.IO;

public class Dungeon
{
    private List<Enemy> _enemies;
    private List<Enemy> _roomEnemies = new List<Enemy>();
    private List<Item> _items;
    private List<Item> _roomItems = new List<Item>();
    private List<Player> _player;
    private Inventory _inventory = new Inventory();
    Random r = new Random();

    //Constuctor
    public Dungeon()
    {
        //Creates a list of all potential enemies
        _enemies = new List<Enemy>();
        string[] lines = System.IO.File.ReadAllLines("enemies.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            _enemies.Add(new Enemy(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2]), Int32.Parse(parts[3]), Int32.Parse(parts[4])));
        }

        //Creates a list of all potential items
        _items = new List<Item>();
        string [] lines2 = System.IO.File.ReadAllLines("items.txt");
        foreach (string line in lines2)
        {
            string[] parts = line.Split("|");
            for (int i = 1; i <= 9; i++)
            {
                _items.Add(new Equipment(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2])));
            }
            for (int i = 10; i <= 12; i++)
            {
                _items.Add(new Potion(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2])));
            }
        }

        //Creates a list of all potential player classes
        _player = new List<Player>();
        string[] lines3 = System.IO.File.ReadAllLines("classes.txt");
        foreach (string line in lines3)
        {
            string[] parts = line.Split("|");
            _player.Add(new Player(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2]), Int32.Parse(parts[3]), Int32.Parse(parts[4])));
        }
    }

    public void GetEnemies()
    {
        int counter = 1;
        foreach (Enemy enemy in _roomEnemies)
        {
            Console.WriteLine($"{counter}) {enemy.GetName()}, {enemy.CurrentHealth}/{enemy.GetMaxHealth()}");
        }
    }
    public List<Item> GetItems()
    {
        return _roomItems;
    }

    //Methods
    //Chooses the player class
    public Player PlayerClass(int choice)
    {
        switch (choice)
        {
            case 1:
                _inventory.AddEquipment(_items[1]);
                _inventory.AddEquipment(_items[4]);
                return _player[0];
            case 2:
                return _player[1];
            case 3:
                return _player[2];
            default:
                Console.WriteLine("That is not an option. Choosing a random class.");
                choice = r.Next(1, 4);
                return _player[choice];
        }
    }

    //Creates the next room
    public void GenerateRoom(int i)
    {
        int inRoom = r.Next(i, 13);
        if (inRoom == 12)
        {
            GenerateLoot();
        }
        else
        {
            GenerateEnemies();
        }
    }

    //Clears data for next room
    public void RoomFinish()
    {
        _roomEnemies.Clear();
        _roomItems.Clear();
    }

    //Generates enemies in current room
    public void GenerateEnemies()
    {
        int enemyType = r.Next(_enemies.Count);
        if (enemyType <= 3)
        {
            int amount = r.Next(1, 4);
            for (int i = 0; i < amount; i++)
            {
                _roomEnemies.Add(_enemies[enemyType]);
            }
        }
        else if (enemyType == 4)
        {
            _roomEnemies.Add(_enemies[enemyType]);
            _roomEnemies.Add(_enemies[enemyType]);
        }
        else if (enemyType > 4 && enemyType <= 7)
        {
            _roomEnemies.Add(_enemies[enemyType]);
        }
    }

    //Generates loot in the current room
    public void GenerateLoot()
    {
        int lootType = r.Next(_items.Count);
        if (lootType <= 9)
        {
            _roomItems.Add(_items[lootType]);
        }
        else if (lootType > 9 && lootType < 12)
        {
            _roomItems.Add(_items[lootType]);
            _roomItems.Add(_items[lootType+1]);
        }
        else if (lootType == 12)
        {
            _roomItems.Add(_items[lootType]);
        }
    }
}