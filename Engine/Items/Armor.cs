using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    public class Armor : Item
    {
        protected int defence;

        public Armor(string name, int price, int id, int defence) : base(name, price, id)
        {
            this.defence = defence;
        }

        public virtual int GetDefence()
        {
            return defence;
        }

        public virtual Armor Clone()
        {
            return new Armor(Name, Price, ID, defence);
        }
    }
}
