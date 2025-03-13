using Engine.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine.Quests
{
    public class KillWolf : Quest
    {
        public Wolf Monster { get; set; }
        public KillWolf(int gold, int exp, int cnt) : base(gold, exp, cnt)
        {
            NeededNumber = 1;
            Monster = new Wolf();
            Name = "Kill Wolf";
            Info = "Kill a wolf that annoys villagers.";
        }
    }
}
