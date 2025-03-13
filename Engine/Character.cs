using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Quests;

namespace Engine
{
    public class Character
    {
        private int maxHealth = 10;
        private int health;
        private int exp;
        private int levelPoints = 10;

        public int Moves { get; set; }
        public int Health 
        { 
            get
            {
                return health;
            }
            set
            {
                if (value > maxHealth) Health = maxHealth;
                else
                {
                    health = value;
                }
            }
        }
        public int Level { get; set; }
        public int Exp 
        {  
            get
            {
                return exp;
            }
            set
            {
                exp = value;
                if (exp >= levelPoints * Level)
                {
                    int help = exp;
                    while (help >= levelPoints * Level)
                    {
                        Level++;
                        levelPoints++;
                        maxHealth = maxHealth + 3 * Level;
                        help -= levelPoints * Level;
                    }
                }
            }
        }
        public int Gold { get; set; }
        public string Name { get; set; }
        public Quest ActiveQuest { get; set; }
        public int KillCount { get; set; }
        public Equipment MyEquipment { get; set; }

        public int GetMaxHealth()
        {
            return maxHealth;
        }
    }
}
