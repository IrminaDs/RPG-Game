using Engine.Items;
using Engine.Quests;
using Engine.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Locations
{
    public class Castle : Location
    {
        public Castle(int xCoordinate, int yCoordinate, string name, string info, string imageInfo, List<Item> items, bool trade, bool change, bool quest) : base(xCoordinate, yCoordinate, name, info, imageInfo, items, trade, change, quest)
        {
        }
        public Castle(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)
        {
            Name = "Castle";
            ImageInfo = @"\Engine\Images\Locations\Castle.png";
            Info = "Evil king: \n - You can't defeat me. I AM INVINCIBLE!";
        }

        public override void SpawnMonster(Quest quest, Character player) 
        {
            ActiveMonster = new Boss();
        }
    }
}
