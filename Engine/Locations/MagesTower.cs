using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Items;

namespace Engine.Locations
{
    public class MagesTower : Location
    {
        public MagesTower(int xCoordinate, int yCoordinate, string name, string info, string imageInfo, List<Item> items, bool trade, bool change, bool quest) : base(xCoordinate, yCoordinate, name, info, imageInfo, items, trade, change, quest)
        {
        }
        public MagesTower(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)
        {
            Name = "Mage's Tower";
            Info = "Mage:\n - Well, hello there. Please browse my goods freely... Just maybe don't shake them to much.";
            ImageInfo = @"\Engine\Images\Locations\MagesTower.png";
            Trading = true;

            items.Add(ItemFactory.CreateItem(1));
            items.Add(ItemFactory.CreateItem(2));
            items.Add(ItemFactory.CreateItem(3));
            items.Add(ItemFactory.CreateItem(4));
            foreach (Item item in items) item.Quantity = 99;
        }
    }
}
