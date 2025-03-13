using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Monsters;

namespace Engine.Quests
{
    public class KillMonsters : Quest
    {
        public Monster Monster {  get; set; }

        public KillMonsters(int gold, int exp, int cnt, Monster monster) : base(gold, exp, cnt)
        { 
            NeededNumber = cnt;
            Monster = monster;
            Name = "Monster Hunter";
            Info = "Kill " + cnt + " " + monster.Name + "s.";
        }
    }
}
