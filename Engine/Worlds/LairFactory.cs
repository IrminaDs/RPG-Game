using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Engine.Locations;

namespace Engine.Worlds
{
    public class LairFactory : WorldFactory
    {
        private int x = 0;
        private int y = 0;
        private World lair;
        public override World CreateWorld()
        {
            lair = new Lair();
            MonstersLair start = new MonstersLair(x, y);
            lair.AddLocation(start);

            Random rnd = new Random();
            for (int i = -1; i < 2; i+=2)
            {
                int l = rnd.Next(0, 2);
                if (l == 0 && lair.LocationAt(i, y) == null)
                {
                    MonstersLair loc = new MonstersLair(i, y);
                    lair.AddLocation(loc);
                }
                l = rnd.Next(0, 2);
                if (l == 0 && lair.LocationAt(i, y) == null)
                {
                    MonstersLair loc = new MonstersLair(x, i);
                    lair.AddLocation(loc);
                }
            }
            return lair;
        }
        public override World UpdateWorld(World world, int xp, int yp)
        {
            lair = world;
            x = xp;
            y = yp;
            Random rnd = new Random();
            for (int i = -1; i < 2; i += 2)
            {
                int l = rnd.Next(0, 2);
                if (l == 0 && lair.LocationAt(x + i, y) == null)
                {
                    MonstersLair loc = new MonstersLair(x + i, y);
                    lair.AddLocation(loc);
                }
                l = rnd.Next(0, 2);
                if (l == 0 && lair.LocationAt(x, y + i) == null)
                {
                    MonstersLair loc = new MonstersLair(x, y + i);
                    lair.AddLocation(loc);
                }
            }
            return lair;
        }
    }
}
