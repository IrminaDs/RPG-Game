using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Items;
using Engine.Monsters;
using Engine.Quests;

namespace Engine.Locations
{
    public class MonstersLair : Location
    {
        private Random random = new Random();
        public MonstersLair(int xCoordinate, int yCoordinate, string name, string info, string imageInfo, List<Item> items, bool trade, bool change, bool quest) : base(xCoordinate, yCoordinate, name, info, imageInfo, items, trade, change, quest)
        {
        }
        public MonstersLair(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)
        {
            Name = "Monsters' Lair";
            Info = "You get the feeling that the forest is watching you";
            ImageInfo = @"\Engine\Images\Locations\MonstersLair.png";
        }

        public override void SpawnMonster(Quest quest, Character player)
        {
            if (quest != null && quest.GetType() == typeof(KillWolf) && player.Moves == 10)
            {
                ActiveMonster = new Wolf();
            }
            else
            {
                int l = random.Next(1, 10);
                if (l != 9)
                {
                    int n = random.Next(1, 10);
                    if (n + player.Moves <= 10)
                    {
                        ActiveMonster = Monsters[0];
                    }
                    else if (n + player.Moves <= 20)
                    {
                        ActiveMonster = Monsters[1];
                    }
                    else
                    {
                        ActiveMonster = Monsters[2];
                    }
                }
            }
        }


    }
}
