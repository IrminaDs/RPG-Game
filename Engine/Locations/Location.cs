using Engine.Monsters;
using Engine.Items;
using Engine.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Locations
{
    public abstract class Location
    {
        protected List<Item> items; 
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string ImageInfo { get; set; }
        public List<Monster> Monsters { get; set; }
        public Monster ActiveMonster { get; set; }
        public bool Trading { get; set; }
        public bool Changing { get; set; }
        public bool Quest {  get; set; }

        public QuestFactory QuestFactory { get; set; }

        public Location(int xCoordinate, int yCoordinate, string name, string info, string imageInfo, List<Item> list, bool trade, bool change, bool quest)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Name = name;
            Info = info;
            ImageInfo = imageInfo;
            items = list;
            Trading = trade;
            Changing = change;
            Quest = quest;
            Monsters = new List<Monster>();

            Monsters.Add(new Ghost());
            Monsters.Add(new Werewolf());
            Monsters.Add(new Golem());
        }

        public Location(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            items = new List<Item>();
            Trading = false;
            Changing = false;
            Quest = false;
            Monsters = new List<Monster>();

            Monsters.Add(new Ghost());
            Monsters.Add(new Werewolf());
            Monsters.Add(new Golem());
        }

        public virtual void SpawnMonster(Quest quest, Character player) { }

        public List<Item> Trade()
        {
            if (Trading) return items;
            else return new List<Item>();
        }

        public Quest GiveQuest()
        {
            return QuestFactory.CreateQuest();
        }
    }
}
