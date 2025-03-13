using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Monsters
{
    internal class Golem : Monster
    {
        public Golem()
        {
            Name = "Golem";
            Health = 23;
            Exp = 15;
            Gold = 17;
            ImageName = @"\Engine\Images\Monsters\Golem.png";
            attack = 10;
        }
    }
}
