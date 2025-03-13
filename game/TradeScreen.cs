using Engine;
using Engine.Items;
using Engine.Locations;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace game
{
    public partial class TradeScreen : Form
    {
        private Character character;
        private Game game;
        public TradeScreen(Character player, Game game)
        {
            character = player;
            this.game = game;
            InitializeComponent();

            trd.Text = game.GetSession().CurrentLocation.Name;
            Location loc = game.GetSession().CurrentLocation;
            if (loc.GetType() == typeof(MagesTower)) inventory.DataSource = character.MyEquipment.GetItems();
            if (loc.GetType() == typeof(Smithy))
            {
                inventory.DataSource = character.MyEquipment.GetArmament();
            }
            Trader.DataSource = loc.Trade();
        }

        private void inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var id = inventory.Rows[e.RowIndex].Cells[2].Value;
                Item item = ItemFactory.CreateItem((int)id);

                if ((int)inventory.Rows[e.RowIndex].Cells[3].Value > 0)
                {
                    character.Gold += item.Price;
                    if (game.GetSession().CurrentLocation.GetType() == typeof(MagesTower)) character.MyEquipment.RemoveItem((int)id);
                    if (game.GetSession().CurrentLocation.GetType() == typeof(Smithy))
                    {
                        character.MyEquipment.RemoveArmament((int)id);
                    }
                    inventory.Refresh();
                    Trader.Refresh();
                }
                else
                {
                    MessageBox.Show("You don't have any " + item.Name + "s.");
                }
            }
            game.UpdateItems();
            game.UpdateWeapons();
            game.UpdateArmors();
            game.ChangeTexts();
        }
        private void Trader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Trader.Rows[e.RowIndex].Cells[2].Value;
            Item item = ItemFactory.CreateItem((int)id);
            if (e.ColumnIndex == 5)
            {
                if (character.Gold < item.Price) MessageBox.Show("You don't have enough Gold to buy " + item.Name + ".");
                else
                {
                    character.Gold -= item.Price;
                    if (game.GetSession().CurrentLocation.GetType() == typeof(MagesTower)) character.MyEquipment.AddItem((int)id);
                    if (game.GetSession().CurrentLocation.GetType() == typeof(Smithy))
                    {
                        character.MyEquipment.AddArmament((int)id);
                    }
                    Trader.Refresh();
                    inventory.Refresh();
                }
            }
            if (e.ColumnIndex == 4)  MessageBox.Show(item.Info);
            game.UpdateItems();
            game.UpdateWeapons();
            game.UpdateArmors();
            game.ChangeTexts();
        }
        private void cls_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
