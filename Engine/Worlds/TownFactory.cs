using Engine.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Worlds
{
    public class TownFactory : WorldFactory
    {
        public override World CreateWorld()
        {
            World town = new Town();
            Location inn = new Inn(0, 0);
            Location smithy = new Smithy(1, 0);
            Location mage = new MagesTower(-1, 0);
            Location castle = new Castle(0, -1);
            Location lair = new MonstersLair(0, 1);
            town.AddLocation(inn);
            town.AddLocation(smithy);
            town.AddLocation(mage);
            town.AddLocation(castle);
            town.AddLocation(lair);
            return town;
        }
        public override World UpdateWorld(World world, int xp, int yp)
        {
            return world;
        }
    }
}
