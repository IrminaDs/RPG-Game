using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Monsters
{
    internal class Ghost : Monster
    {
        private Random random = new Random();
        public Ghost()
        {
            Name = "Ghost";
            Health = 5;
            Exp = 5;
            Gold = 3;
            ImageName = @"\Engine\Images\Monsters\Ghost.png";
            attack = 1;
        }

        public override int Attack()
        {
            int l = random.Next(1, 3);
            return attack * l;
        }
    }
}
