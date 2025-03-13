using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    public interface IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ID { get; set; }
        public int Quantity { get; set; }
    }
}
