public abstract class Item
{
    private string _name;
    
    //Constructor
    public Item(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    //Abstract display method
    public abstract void Display();
}