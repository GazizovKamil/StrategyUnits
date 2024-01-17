using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Archer : MilitaryUnit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Archer() : base(50, "Archer")
        {
            _damage = 4;
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }
    }
}
