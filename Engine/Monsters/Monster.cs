using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Monsters
{
    public abstract class Monster
    {
        protected int attack;
        public int Health { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public int Exp {  get; set; }
        public int Gold { get; set; }
        protected Monster() { }

        public virtual int Attack()
        {
            return attack;
        }
    }
}
