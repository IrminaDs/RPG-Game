using Engine.Worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class StateInn : StateOfWorld
    {
        public override void MoveSouth()
        {
            Session.Factory = new LairFactory();
            Session.ActiveWorld = Session.Factory.CreateWorld();
            Session.X = 0; Session.Y = 0;
            Session.CurrentLocation = Session.ActiveWorld.LocationAt(Session.X, Session.Y);
            Session.State = new StateNormal();
            Session.State.Session = Session;
            Session.Player.Moves = 0;
        }
    }
}
