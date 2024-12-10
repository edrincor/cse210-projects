using System.IO;
using System.Xml.Serialization;

public class Dungeon
{
    private int _roomNumber;
    private List<Enemy> _enemies;
    private List<Enemy> _roomEnemies = new List<Enemy>();
    private List<Item> _items;
    private List<Item> _roomItems = new List<Item>();
    Random r = new Random();

    //Constuctor
    public Dungeon()
    {
        _roomNumber = 1;

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
    }

    public List<Enemy> GetEnemies()
    {
        return _roomEnemies;
    }
    public List<Item> GetItems()
    {
        return _roomItems;
    }

    //Methods
    //Creates the next room
    public void GenerateRoom()
    {
        int inRoom = r.Next(_roomNumber, 13);
        if (inRoom == 12)
        {
            GenerateLoot();
        }
        else
        {
            GenerateEnemies();
        }
    }

    //Updates and clears data for next room
    public void RoomFinish()
    {
        _roomNumber++;
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