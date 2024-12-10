public class Fight
{
    Random r = new Random();

    //Character attacking enemy
    public void Attack(Character character, Enemy enemy)
    {
        int attack = r.Next(1, 13);
        attack += character.GetToHit();
        if (attack >= enemy.GetArmor())
        {
            Console.WriteLine($"A hit! You did {character.GetDamage()} damage!");
            enemy.CurrentHealth -= character.GetDamage();
        }
        else
        {
            Console.WriteLine("Oh no, you missed!");
        }
    }
    //Enemy attacking character
    public void Attack(Enemy enemy, Character character)
    {
        Console.WriteLine($"{enemy} attacks!");
        int attack = r.Next(1, 13);
        attack += enemy.GetToHit();
        if (attack >= character.GetArmor())
        {
            Console.WriteLine($"You got hit for {enemy.GetDamage()} damage!");
            character.CurrentHealth -= enemy.GetDamage();
        }
        else
        {
            Console.WriteLine($"You avoided the attack!");
        }
    }

    //Character using item during fight
    public void UsePotion(Potion potion)
    {
        
    }
}