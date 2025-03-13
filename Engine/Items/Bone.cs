using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    internal class Bone : Weapon
    {
        public Bone(string name, int price, int id, int strength) : base(name, price, id, strength) { }

        public override Weapon Clone()
        {
            return new Bone(Name, Price, ID, strength);
        }
    }
}
