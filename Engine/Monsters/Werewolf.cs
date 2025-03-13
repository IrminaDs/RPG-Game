using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Monsters
{
    internal class Werewolf : Monster
    {
        private int charge;
        private Random random;
        public Werewolf()
        {
            Name = "Werewolf";
            Health = 15;
            Exp = 8;
            Gold = 10;
            ImageName = @"\Engine\Images\Monsters\Werewolf.png";
            attack = 4;
            charge = 0;
            random = new Random();
        }

        public override int Attack()
        {
            int i = random.Next(0,2);
            if (charge == 0)
            {
                if (i == 0) return attack;
                else
                {
                    charge = 1;
                    return attack / 2;
                }
            }
            else
            {
                charge = 0;
                return attack * 2;
            }
        }
    }
}
