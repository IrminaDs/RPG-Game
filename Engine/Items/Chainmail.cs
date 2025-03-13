using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    internal class Chainmail : Armor
    {
        public Chainmail(string name, int price, int id, int defence) : base(name, price, id, defence)
        {
            Info = "Blocks " + defence + " damage.";
        }

        public override Armor Clone()
        {
            return new Chainmail(Name, Price, ID, defence);
        }
    }
}
