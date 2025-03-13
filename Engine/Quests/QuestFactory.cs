using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Monsters;

namespace Engine.Quests
{
    public class QuestFactory
    {
        private Character character;
        private List<Monster> monsters;
        private Random random;
        private bool specialquest;

        public QuestFactory(Character character, List<Monster> monsters) 
        { 
            this.character = character;
            this.monsters = monsters;
            random = new Random();
            specialquest = true;
        }
        public Quest CreateQuest()
        {
            if (specialquest)
            {
                if (character.Level >= 10)
                {
                    specialquest = false;
                    return new KillWolf(50, 50, 1);
                }
            }
            if (character.Level == 1)
            {
                int num = random.Next(2, 6);
                return new KillMonsters(monsters[0].Gold * num, monsters[0].Exp * num, num, monsters[0]);
            }
            int count = monsters.Count;
            int monsterID = random.Next(0,count); 
            Monster monster = monsters[monsterID];
            int number = random.Next(2,6);
            return new KillMonsters(monster.Gold * number, monster.Exp * number, number, monster);
        }
    }
}
