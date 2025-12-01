using System.Text.Json;

public class Character(string name, int health, int armor, int attack)
{
    public string Name = name;
    public int Health = health;
    public int Armor = armor;
    public int Attack = attack;
    public List<Item> Inventory = [];
    public List<Ability> AvailableAbilitites = [];
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool Completed { get; set; }
    private readonly HttpClient _httpClient = new HttpClient();
    public void AttackCharacter(Character target)
    {
        target.Health -= this.Attack;
    }
    public void DefenseCharacter(Character character)
    {
        character.Health = character.Health;
    }
    public void HealCharacter(Character character, int healAmount)
    {
        character.Health += healAmount;
    }
    public async Task<Todo> GetCharacterAsync(string url)
    {
        var response = await _httpClient.GetStringAsync(url);
        var character = JsonSerializer.Deserialize<Todo>(response);
        return character;
    }
}