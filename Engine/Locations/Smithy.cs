using Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Locations
{
    public class Smithy : Location
    {
        public Smithy(int xCoordinate, int yCoordinate, string name, string info, string imageInfo, List<Item> items, bool trade, bool change, bool quest) : base(xCoordinate, yCoordinate, name, info, imageInfo, items, trade, change, quest)
        {
        }
        public Smithy(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)
        {
            Name = "Smithy";
            Info = "Blacksmith:\n - ...\n\n (You can buy armor and weapons here.)";
            ImageInfo = @"\Engine\Images\Locations\Smithy.png";
            Trading = true;

            items.Add(ItemFactory.CreateItem(1001));
            items.Add(ItemFactory.CreateItem(1002));
            items.Add(ItemFactory.CreateItem(1003));
            items.Add(ItemFactory.CreateItem(1004));
            items.Add(ItemFactory.CreateItem(2001));
        }
    }
}
