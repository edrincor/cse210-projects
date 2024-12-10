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
}