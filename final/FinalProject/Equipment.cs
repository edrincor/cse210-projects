public class Equipment : Item
{
    private string _type;
    private int _amount;

    public Equipment(string name, int type, int amount) : base(name)
    {
        switch (type)
        {
            case 1:
                _type = "damage";
                break;
            case 2:
                _type = "armor";
                break;
            case 3:
                _type = "toHit";
                break;
        }
        _amount = amount;
    }

    public override void Display()
    {
        Console.WriteLine($"Item: {GetName()}");
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Increases by: {_amount}");
    }

    public string GetEquipType()
    {
        return _type;
    }
    public int GetAmount()
    {
        return _amount;
    }
}