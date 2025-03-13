using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Monsters
{
    public class Boss : Monster
    {
        private Random random;
        public bool Spec {  get; private set; }
        public Boss()
        {
            Name = "Evil King";
            Health = 200;
            Exp = 100;
            Gold = 100;
            ImageName = @"\Engine\Images\Monsters\Boss.png";
            attack = 25;
            random = new Random();
            Spec = false;
        }

        public int Charge()
        {
            Spec = true;
            return 0;
        }

        public int PowerfulAttack()
        {
            Spec = false;
            return attack * 2;
        }

        public int Slash()
        {
            int l = random.Next(0, 6);
            return 10 + l;
        }
    }
}
