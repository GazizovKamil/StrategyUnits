namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Berserker() : base(90, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }
    }
}
