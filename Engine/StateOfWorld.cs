using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Locations;
using Engine.Worlds;

namespace Engine
{
    public abstract class StateOfWorld
    {
        public GameSession Session { get; set; }
        public abstract void MoveSouth();
    }
}
