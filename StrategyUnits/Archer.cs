using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Archer : MilitaryUnit
    {
        private int _arrows_count;

        public Archer() : base(20, "Archer", 5) { }

        public void ShootArrow(Unit unit)
        {
            if (_arrows_count > 0)
            {
                unit.Health += this.Damage;
                _arrows_count--;
            }
            else
            {
                Console.WriteLine(this.Name + " arrows 0");
            }
        }
    }
}
