using Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Locations
{
    public class Inn : Location
    {   
        public Inn(int xCoordinate, int yCoordinate, string name, string info, string imageInfo, List<Item> items, bool trade, bool change, bool quest) : base(xCoordinate, yCoordinate, name, info, imageInfo, items, trade, change, quest)
        {
        }
        public Inn(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate)
        {
            Name = "Inn";
            ImageInfo = @"\Engine\Images\Locations\Inn.png";
            Changing = true;
            Quest = true;
            Info = "Inkeeper: \n - You can stay as long as you make yourself useful. \n\nHere you can take quests and change your armor. Also every time you pass by your Health will renewed.";
        }
    }
}
