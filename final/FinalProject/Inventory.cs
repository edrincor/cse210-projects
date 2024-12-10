public class Inventory
{
    private List<Item> _inventory = new List<Item>();

    public void DisplayInventory()
    {
        Console.WriteLine("");
    }

    public void AddEquipment(Equipment equipment)
    {
        _inventory.Add(equipment);
    }
    public void AddPotion(Potion potion)
    {
        _inventory.Add(potion);
    }

}