public class Player : Character
{
    private string _playerClass;
    Random r = new Random();
    public Player(string name, int maxHealth, int baseDamage, int toHit, int baseArmor, string playerClass) : base(name, maxHealth, baseDamage, toHit, baseArmor)
    {
        _playerClass = playerClass;
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