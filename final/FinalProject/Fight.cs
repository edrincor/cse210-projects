public class Fight
{
    Random r = new Random();

    //Character attacking enemy
    public void PlayerAttack(Player player, Enemy enemy)
    {
        int attack = r.Next(1, 13);
        attack += player.GetToHit();
        if (attack >= enemy.GetArmor())
        {
            Console.WriteLine($"A hit! You did {player.GetDamage()} damage!");
            enemy.CurrentHealth -= player.GetDamage();
            if (player.CriticalHit())
            {
                Console.WriteLine($"It's a Critical Hit! Extra {player.GetDamage()} damage!");
                enemy.CurrentHealth -= player.GetDamage();
            }
        }
        else
        {
            Console.WriteLine("Oh no, you missed!");
        }
    }
    //Enemy attacking character
    public void EnemyAttack(Enemy enemy, Player player)
    {
        Console.WriteLine($"{enemy} attacks!");
        int attack = r.Next(1, 13);
        attack += enemy.GetToHit();
        if (attack >= player.GetArmor())
        {
            Console.WriteLine($"You got hit for {enemy.GetDamage()} damage!");
            player.CurrentHealth -= enemy.GetDamage();
        }
        else
        {
            Console.WriteLine($"You avoided the attack!");
        }
    }

    //Character using a potion during fight
    public int UsePotion(Potion potion, Character character)
    {
        if (potion.GetPotionType() == "strength")
        {
            return 1;
        }
        else if (potion.GetPotionType() == "health")
        {
            if (character.CurrentHealth + 8 <= character.GetMaxHealth())
            {
                character.CurrentHealth += 8;
            }
            else 
            {
                character.CurrentHealth = character.GetMaxHealth();
            }
            return 2;
        }
        else if (potion.GetPotionType() == "speed")
        {
            return 3;
        }
        return 0;
        
    }
}