public class Enemy : Character
{
    public Enemy(string Name, int Health, int Armor, int Attack) : base(Name, Health, Armor, Attack)
    {
    }

    public int Rage { get; set; }
    public void Enrage()
    {
        this.Rage += 10;
        this.Attack += 5;
    }
}