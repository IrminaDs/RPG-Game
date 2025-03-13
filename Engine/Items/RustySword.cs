using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    internal class RustySword : Weapon
    {
        public RustySword(string name, int price, int id, int strength) : base(name, price, id, strength) 
        {
            Info = "Deals " + strength + " damage. There's a one-fifth chance that the damage will be doubled.";
        }

        public override int GetAttackStrength()
        {
            Random rnd = new Random();
            int r = rnd.Next(1,6);
            int attack = strength;
            if (r == 0) attack = attack * 2;
            return attack;
        }

        public override Weapon Clone()
        {
            return new RustySword(Name, Price, ID, strength);
        }
    }
}
