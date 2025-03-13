using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class StateNormal : StateOfWorld
    {
        public override void MoveSouth()
        {
            Session.Y += 1;
            Session.CurrentLocation = Session.ActiveWorld.LocationAt(Session.X, Session.Y);
            Session.ActiveWorld = Session.Factory.UpdateWorld(Session.ActiveWorld, Session.X, Session.Y);
            Session.Player.Moves++;
            Session.SpawnMonster();
        }
    }
}
