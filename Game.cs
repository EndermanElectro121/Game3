using System.Threading;

public class Game
{
    public List<Character> characters = new List<Character>();
    public List<Enemy> enemies = new List<Enemy>(); 
    public void create(string type)
    {
        Console.WriteLine($"Creating a new {type}");
        Console.WriteLine("Enter your character's name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your character's health");
        int health = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your character's armor");
        int armor = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your character's attack");
        int attack = int.Parse(Console.ReadLine());
        Character character = new Character("character", 0, 0, 0);
        character.Name = name;
        character.Health = health;
        character.Armor = armor;
        character.Attack = attack;
        Character hero = new Character(character.Name, character.Health, character.Armor, character.Attack);
        Console.WriteLine("Enter your enemy's name:");
        string enemyName = Console.ReadLine();
        Console.WriteLine("Enter your enemy's health");
        int enemyHealth = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your enemy's armor");
        int enemyArmor = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your enemy's attack");
        int enemyAttack = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your enemy's rage");
        int rage = int.Parse(Console.ReadLine());
        Enemy enemy = new Enemy("enemy", 0, 0, 0) { Rage = 0 };
        enemy.Name = enemyName;
        enemy.Health = enemyHealth;
        enemy.Armor = enemyArmor;
        enemy.Attack = enemyAttack;
        enemy.Rage = rage;
        Enemy monster = new Enemy(enemy.Name, enemy.Health, enemy.Armor, enemy.Attack) { Rage = enemy.Rage };
        act(hero, enemyName);
        add(hero, enemyName);
        ls(hero, monster, "all");
        equip(hero, "itemId", hero.Name);
        create2();
    }
    public void create2()
    {
        Console.WriteLine("Do you want to create new character and new enemy or nothing?!(enter New or Nothing)");
        string choice = Console.ReadLine();
        if (choice == "New")
        {
            Console.WriteLine($"Creating a new hero");
            Console.WriteLine("Enter your character's name:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter your character's health");
            int health2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your character's armor");
            int armor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your character's attack");
            int attack2 = int.Parse(Console.ReadLine());
            Character character = new Character("character", 0, 0, 0);
            character.Name = name2;
            character.Health = health2;
            character.Armor = armor2;
            character.Attack = attack2;
            Character hero2 = new Character(character.Name, character.Health, character.Armor, character.Attack);
            Console.WriteLine("Enter your enemy's name:");
            string enemyName2 = Console.ReadLine();
            Console.WriteLine("Enter your enemy's health");
            int enemyHealth2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your enemy's armor");
            int enemyArmor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your enemy's attack");
            int enemyAttack2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your enemy's rage");
            int rage2 = int.Parse(Console.ReadLine());
            Enemy enemy = new Enemy("enemy", 0, 0, 0) { Rage = 0 };
            enemy.Name = enemyName2;
            enemy.Health = enemyHealth2;
            enemy.Armor = enemyArmor2;
            enemy.Attack = enemyAttack2;
            enemy.Rage = rage2;
            Enemy monster2 = new Enemy(enemy.Name, enemy.Health, enemy.Armor, enemy.Attack) { Rage = enemy.Rage };
            act(hero2, enemyName2);
            add(hero2, enemyName2);
            ls(hero2, monster2, "all");
            equip(hero2, "itemId", hero2.Name);
            create2();
        }
        else if(choice == "Nothing")
        {
            Console.WriteLine("No creation performed.");
        }
    }    
    public void act(Character character, string actionType, string actorId = "actorId", string targetId = "targetId", string abilityId = "abilityId")
    {
        Console.WriteLine($"{actorId} performs {actionType} on {targetId} using {abilityId}");
        Console.WriteLine("Choose an action: 0. Attack 1. Defend 2. Heal");
        int action = int.Parse(Console.ReadLine());
        if (action == 0)
        {
            Console.WriteLine($"{character.Name} attacks the enemy");
        }
        else if(action == 1)
        {
            Console.WriteLine($"{character.Name} defends");
        }
        else if (action == 2)
        {
            Console.WriteLine($"{character.Name} heals");
        }
        else
        {
            Console.WriteLine("Invalid action");
        }
    }
    public void add(Character character, string charId = "charId", string objectId = "objectId")
    {
        Console.WriteLine($"Adding object {objectId} to character {charId}");
        var abilities = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter an ability to add (or type 'done' to finish):");
            string ability = Console.ReadLine();
            if (ability.ToLower() == "done")
            {
                break;
            }
            else
            {
                abilities.Add(ability);
            }         
        }
        for(int i = 0; i < abilities.Count; i++)
        {
            Console.WriteLine(abilities[i]);
        }
    }
    public void ls(Character character, Enemy enemy, string type, string id = null)
    {
        characters.Add(character);
        enemies.Add(enemy);
        Console.WriteLine($"Listing {type} {(id != null ? $"with id {id}" : "")}");
        Console.WriteLine("Character List:");
        for (int i = 0; i < characters.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {characters[i].Name} health: {characters[i].Health}, armor: {characters[i].Armor}, attack: {characters[i].Attack}");
        }
        Console.WriteLine("Enemy List:");
        for (int i = 0; i < enemies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {enemies[i].Name} health: {enemies[i].Health}, armor: {enemies[i].Armor}, attack: {enemies[i].Attack}");
        }
    }
    public void equip(Character character, string itemId = "itemId", string charId = "charId")
    {
        Console.WriteLine($"Equipping item {itemId} to character {charId}");
        Console.WriteLine("Enter the item name to equip:");
        string itemName = Console.ReadLine();
        Console.WriteLine($"{character.Name} has equipped {itemName}");
    }
}

