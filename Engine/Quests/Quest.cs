using Engine.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Quests
{
    public abstract class Quest
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Gold { get; set; }
        public int Exp { get; set; }
        public bool Completed { get; set; }
        public int Counter { get; set; }
        public int NeededNumber { get; set; }

        public Quest(int gold, int exp, int cnt)
        {
            Gold = gold;
            Exp = exp;
            Completed = false;
            Counter = 0;
            NeededNumber = cnt;
        }
    }
}
