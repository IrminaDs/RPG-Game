using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ID { get; set; }
        public int Quantity { get; set; }
        public string Info { get; set; }

        public Item(string name, int price, int id)
        {
            Name = name;
            Price = price;
            ID = id;
            Quantity = 1;
        }

        public virtual Item Clone()
        {
            return new Item(Name, Price, ID);
        }

        public virtual string Use(Character character)
        {
            return "You tried use " + Name + " but nothing happened. \n";
        }
    }
}
