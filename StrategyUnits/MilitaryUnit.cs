namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _currentHealth;
        private string? _name;
        public int MaxHealth { get; private set; }

        public MilitaryUnit(int health, string? name) : base(0, "")
        {
            _currentHealth = health;
            _name = name;
            MaxHealth = health;
        }
    }
}
