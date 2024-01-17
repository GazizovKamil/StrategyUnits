namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string? name, int damage) : base(60, "Footman", 5)
        {
            Health = health;
            Name = name;
            MaxHealth = health;
            Damage = damage;
        }

        public Footman() : base(60, "Footman", 5)
        {
           
        }
    }
}
