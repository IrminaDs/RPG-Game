using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    public class Weapon : Item
    {
        protected int strength;
        public Weapon(string name, int price, int id, int strength) : base(name, price, id)
        {
            this.strength = strength;
            Info = "Deals " + strength + " damage.";
        }
        public virtual new Weapon Clone()
        {
            return new Weapon(Name, Price, ID, strength);
        }

        public virtual int GetAttackStrength()
        {
            return strength;
        }
    }
}
