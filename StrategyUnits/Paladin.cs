using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin(int health, int manna, string? name, int magic_damage, int damage) : base(20, 40, "Palladin", 10, 2)
        {
            Health = health;
            Manna = manna;
            Name = name;
            MaxHealth = health;
            MagicDamage = magic_damage;
            Damage = damage;
        }

        public void MagicHit(Unit unit)
        {
            if (Manna > MagicDamage)
            {
                unit.Health -= this.MagicDamage;
                this.Manna -= this.MagicDamage;
            }
            else if(MagicDamage > 0)
            {
                unit.Health -= this.Manna;
                this.Manna = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " manna 0");
            }
        }
    }
}
