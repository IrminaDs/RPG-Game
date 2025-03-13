using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Items
{
    internal class HealthPotion : Item
    {
        private int healing;
        public HealthPotion(string name, int price, int id, int healing) : base(name, price, id)
        {
            this.healing = healing;
            Info = "Gives you " + healing + " health.";
        }
        public override string Use(Character character)
        {
            character.Health += healing;
            return "You use: " + Name + ". \n";
        }

        public override Item Clone()
        {
            return new HealthPotion(Name, Price, ID, healing);
        }
    }
}
