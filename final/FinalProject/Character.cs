public class Character
{
    private string _name;
    private int _maxHealth;
    private int _baseDamage;
    private int _toHit;
    private int _baseArmor;

    public Character()
    {

    }
    public Character(string name, int maxHealth, int baseDamage, int toHit, int baseArmor)
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }
}