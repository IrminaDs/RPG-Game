using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Monsters
{
    public class Wolf : Monster
    {
        public Wolf()
        {
            Name = "Wolf";
            Health = 70;
            Exp = 70;
            Gold = 10;
            ImageName = @"\Engine\Images\Monsters\Wolf.png";
            attack = 10;
        }
    }
}
