public class Potion : Item
{
    private string _type;
    private int _amount;

    public Potion(string name, int type, int amount) : base(name)
    {
        switch (type)
        {
            case 1:
                _type = "strength";
                break;
            case 2:
                _type = "health";
                break;
            case 3:
                _type = "speed";
                break;
        }
        _amount = amount;
    }
}