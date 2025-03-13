using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Worlds
{
    public abstract class WorldFactory
    {
        public abstract World CreateWorld();
        public abstract World UpdateWorld(World world, int xp, int yp);
    }
}
