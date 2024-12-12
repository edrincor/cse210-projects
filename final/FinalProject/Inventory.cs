public class Inventory
{
    private List<Item> _inventory = new List<Item>();
    int counter = 0;

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory");
        foreach (var item in _inventory)
        {
            Console.Write($"{counter})");
            item.Display();
            counter++;
        }
    }

    public void AddEquipment(Item equipment)
    {
        _inventory.Add(equipment);
    }
    public void AddPotion(Item potion)
    {
        _inventory.Add(potion);
    }

}