using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    internal class Saber : Weapon
    {
        private Random random;
        public Saber(string name, int price, int id, int strength) : base(name, price, id, strength)
        {
            random = new Random();
            int atk = strength + 5;
            Info = "Deals " + strength + "-" + atk + " damage.";
        }

        public override int GetAttackStrength()
        {
            int l = random.Next(0, 6);
            return strength + l;
        }
        public override Weapon Clone()
        {
            return new Saber(Name, Price, ID, strength);
        }
    }
}
