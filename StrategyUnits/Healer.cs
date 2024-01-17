using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _manna;

        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }

        public Healer() : base(20, "Doctor")
        {
            _manna = 40;
        }

        public void Healing(Unit unit)
        {
            unit.Health += 10;
            _manna -= 10;
        }
    }
}
