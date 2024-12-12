using System.IO;

public class Player : Character
{
    private Inventory _inventory = new Inventory();
    private string _playerClass;
    Random r = new Random();
    public Player(string name, int maxHealth, int baseDamage, int toHit, int baseArmor) : base(name, maxHealth, baseDamage, toHit, baseArmor)
    {
        _playerClass = name;
    }
    
    public Inventory GetInventory()
    {
        return _inventory;
    }
    
    public bool CriticalHit()
    {
        if (_playerClass.ToLower() == "rogue")
        {
            int critical = r.Next(1, 12);
            if (critical >= 8)
            {
                return true;
            }
        }
        return false;
    }

    public bool SorcererHit()
    {
        if (_playerClass.ToLower() == "sorcerer")
        {
            return true;
        }
        return false;
    }
}