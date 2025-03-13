using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Items;

namespace Engine
{
    public class Equipment
    {
        private List<Item> items;
        private List<Item> weapons => armament.Where(i => i is Weapon).ToList();
        private List<Item> armors => armament.Where(i => i is Armor).ToList();
        private List<Item> armament;
        private Item armor;

        public Equipment()
        {
            items = new List<Item>();
            armament = new List<Item>();
            items.Add(ItemFactory.CreateItem(1));
            armament.Add(ItemFactory.CreateItem(1001));
        }

        public void AddItem(int id)
        {
            Item item = items.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                items.Add(ItemFactory.CreateItem(id));
            }
        }

        public void RemoveItem(int id)
        {
            Item item = items.FirstOrDefault(x => x.ID == id);
            if (item != null && item.Quantity > 0)
            {
                item.Quantity--;
            }
        }

        public List<Item> GetItems()
        {  
            return items; 
        }

        public void AddArmament(int id)
        {
            Item weapon = armament.FirstOrDefault(x => x.ID == id);
            if (weapon != null)
            {
                weapon.Quantity++;
            }
            else
            {
                armament.Add(ItemFactory.CreateItem(id));
            }
        }
        public void RemoveArmament(int id) 
        {  
            Item weapon = armament.FirstOrDefault(x => x.ID == id);
            if (weapon != null && weapon.Quantity > 0)
            {
                weapon.Quantity--;
            }
        }

        public List<Item> GetArmament()
        {
            return armament;
        }

        public List<Item> GetWeapons()
        {
            return weapons;
        }

        public List<Item> GetArmors()
        {
            return armors;
        }

        public void SetArmor(Item armor) 
        {
            this.armor = armor;
        }

        public Item GetArmor()
        {
            return armor;
        }

    }
}
