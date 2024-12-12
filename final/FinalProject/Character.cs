public class Character
{
    private string _name;
    private int _maxHealth;
    private int _baseDamage;
    private int _toHit;
    private int _baseArmor;
    private int _currentHealth;
    private int _damageModifier = 0;
    private int _armorModifier = 0;
    private int _toHitModifier = 0;

    //Constructor
    public Character(string name, int maxHealth, int baseDamage, int toHit, int baseArmor)
    {
        _name = name;
        _maxHealth = maxHealth;
        _currentHealth = maxHealth;
        _baseDamage = baseDamage;
        _toHit = toHit;
        _baseArmor = baseArmor;
    }

    //Getters and Setters
    public int CurrentHealth
    {
        get { return _currentHealth; }
        set { _currentHealth = value; }
    }
    public int DamageModifier
    {
        get { return _damageModifier; }
        set { _damageModifier = value; }
    }
    public int ArmorModifier
    {
        get { return _armorModifier; }
        set { _armorModifier = value; }
    }
    public int ToHitModifier 
    {
        get { return _toHitModifier; }
        set { _toHitModifier = value; }
    }
    public int GetArmor()
    {
        return _baseArmor + _armorModifier;
    }
    public int GetDamage()
    {
        return _baseDamage + _damageModifier;
    }
    public int GetToHit()
    {
        return _toHit + _toHitModifier;
    }
    public int GetMaxHealth()
    {
        return _maxHealth;
    }
    public string GetName()
    {
        return _name;
    }
}