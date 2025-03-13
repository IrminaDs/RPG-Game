using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    public static class ItemFactory
    {
        private static List<Item> items;
        static ItemFactory()
        {
            items = new List<Item>();
            items.Add(new PointyStick("Pointy Stick", 1, 1001, 1));
            items.Add(new RustySword("Rusty Sword", 10, 1002, 5));
            items.Add(new Bone("Bone", 5, 1003, 1));
            items.Add(new Saber("Saber", 25, 1004, 10));
            items.Add(new HealthPotion("Small Health Potion", 3, 1, 5));
            items.Add(new HealthPotion("Medium Health Potion", 15, 2, 20));
            items.Add(new HealthPotion("Big Health Potion", 35, 3, 50));
            items.Add(new HealthPotion("Mega Health Potion", 80, 4, 100));
            items.Add(new Chainmail("Chainamail", 15, 2001, 3));
        }

        public static Item CreateItem(int itemID)
        {
            Item gameItem = items.FirstOrDefault(x => x.ID == itemID);
            if (gameItem != null)
            {
                if (gameItem is Weapon)
                {
                    return (gameItem as Weapon).Clone();
                }
                else if (gameItem is Armor)
                {
                    return (gameItem as Armor).Clone();
                }
                return gameItem.Clone();
            }
            return null;
        }
    }
}

