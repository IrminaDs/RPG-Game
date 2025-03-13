using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Locations;

namespace Engine.Worlds
{
    public abstract class World
    {
        protected List<Location> locations = new List<Location>();

        public void AddLocation(Location location)
        {
            locations.Add(location);
        }
        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }

    }
}
