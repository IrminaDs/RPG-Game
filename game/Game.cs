using Engine;
using Engine.Items;
using Engine.Locations;
using Engine.Monsters;
using Engine.Quests;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;
namespace game
{
    public partial class Game : Form
    {
        private GameSession game;
        private bool monsterMsg = false;
        private bool lairMsg = false;
        private bool moved = false;
        public Game()
        {
            InitializeComponent();
            game = new GameSession();
            game.Start();
            moved = true;
            ChangeTexts();
            CheckMoves();
            UpdateItems();
            UpdateWeapons();
            UpdateArmors();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            if (game.ActiveWorld.LocationAt(game.X, game.Y - 1).GetType() == typeof(Castle))
            {
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("You are heading towards the end of the game. Are you sure you want to proceed?", "The end!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    game.MoveNorth();
                    moved = true;
                }
            }
            else game.MoveNorth();
            ChangeTexts();
            CheckMoves();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            game.MoveSouth();
            moved = true;
            ChangeTexts();
            CheckMoves();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            game.MoveWest();
            moved = true;
            ChangeTexts();
            CheckMoves();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            game.MoveEast();
            moved = true;
            ChangeTexts();
            CheckMoves();
        }

        private void CheckMoves()
        {
            btnSouth.Visible = (game.ActiveWorld.LocationAt(game.X, game.Y + 1) != null && game.CurrentLocation.ActiveMonster == null);
            btnNorth.Visible = (game.ActiveWorld.LocationAt(game.X, game.Y - 1) != null && game.CurrentLocation.ActiveMonster == null);
            btnWest.Visible = (game.ActiveWorld.LocationAt(game.X - 1, game.Y) != null && game.CurrentLocation.ActiveMonster == null);
            btnEast.Visible = (game.ActiveWorld.LocationAt(game.X + 1, game.Y) != null && game.CurrentLocation.ActiveMonster == null);
            btnback.Visible = (game.CurrentLocation.Name == "Monsters' Lair" && game.CurrentLocation.ActiveMonster == null);
        }

        public void ChangeTexts()
        {
            if (game.ActiveWorld == game.Town && moved)
            {
                acttxt.Clear();
                acttxt.Text += "You move to " + game.CurrentLocation.Name + ". \n";
                lairMsg = true;
                moved = false;
            }
            if (lairMsg == true && game.CurrentLocation.GetType() == typeof(MonstersLair))
            {
                acttxt.Clear();
                acttxt.Text += "You move to " + game.CurrentLocation.Name + ". \n";
                lairMsg = false;
            }
            lvl.Text = game.Player.Level.ToString();
            exp.Text = game.Player.Exp.ToString();
            hlth.Text = game.Player.Health.ToString();
            gold.Text = game.Player.Gold.ToString();
            Item a = game.Player.MyEquipment.GetArmor();
            if (a == null) amr.Text = string.Empty;
            else amr.Text = a.Name;
            btnWeapon.Visible = (game.CurrentLocation.ActiveMonster != null);
            btnQuest.Visible = (game.CurrentLocation.Quest);
            btnTrade.Visible = (game.CurrentLocation.Trading);
            btnChange.Visible = (game.CurrentLocation.Changing);
            cboChange.Visible = (game.CurrentLocation.Changing);
            if (game.CurrentLocation.ActiveMonster != null && monsterMsg == false)
            {
                acttxt.Text += "You encoutered a " + game.CurrentLocation.ActiveMonster.Name + ". \n";
                monsterMsg = true;
            }
            else if (game.CurrentLocation.ActiveMonster == null) monsterMsg = false;
            acttxt.SelectionStart = acttxt.Text.Length;
            acttxt.ScrollToCaret();
            spctxt.Text = game.CurrentLocation.Info;

            string path = "";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
            if (game.CurrentLocation.ActiveMonster != null)
            {
                path = game.CurrentLocation.ActiveMonster.ImageName;
            }
            else
            {
                path = game.CurrentLocation.ImageInfo;
            }
            path = projectDirectory + path;
            Pic.Image = Image.FromFile(path);
        }

        public void UpdateItems()
        {
            foreach (Item item in game.Player.MyEquipment.GetItems())
            {
                if (item.Quantity > 0 && !cboItems.Items.Contains(item)) cboItems.Items.Add(item);
                else if (item.Quantity <= 0) cboItems.Items.Remove(item);
            }
            cboItems.DisplayMember = "Name";
        }

        public void UpdateWeapons()
        {
            foreach (Item weapon in game.Player.MyEquipment.GetWeapons())
            {
                if (weapon.Quantity > 0 && !cboWeapons.Items.Contains(weapon)) cboWeapons.Items.Add(weapon);
                else if (weapon.Quantity <= 0) cboWeapons.Items.Remove(weapon);
            }
            cboWeapons.DisplayMember = "Name";
        }

        public void UpdateArmors()
        {
            foreach (Item armor in game.Player.MyEquipment.GetArmors())
            {
                if (armor.Quantity > 0 && !cboChange.Items.Contains(armor)) cboChange.Items.Add(armor);
                else if (armor.Quantity <= 0) cboChange.Items.Remove(armor);
            }
            cboChange.DisplayMember = "Name";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            game.MoveToTown();
            acttxt.Clear();
            CheckMoves();
            ChangeTexts();
        }

        private void btnWeapon_Click(object sender, EventArgs e)
        {
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
            if (game.CurrentLocation.GetType() == typeof(Castle))
            {
                acttxt.Text += game.BossFight(currentWeapon);
                if (game.CurrentLocation.ActiveMonster == null)
                {
                    MessageBox.Show("Congratulations! You beated the game.");
                    Application.Exit();
                }
            }
            else
            {
                acttxt.Text += game.Fight(currentWeapon);
            }
            if (game.Player.Health <= 0)
            {
                MessageBox.Show("You died.");
                Application.Exit();
            }
            ChangeTexts();
            CheckMoves();
            UpdateWeapons();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Item currentItem = (Item)cboItems.SelectedItem;
            if (currentItem != null)
            {
                acttxt.Text += currentItem.Use(game.Player);
                game.Player.MyEquipment.RemoveItem(currentItem.ID);
            }
            ChangeTexts();
            CheckMoves();
            UpdateItems();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            TradeScreen tradeScreen = new TradeScreen(game.Player, this);
            tradeScreen.StartPosition = FormStartPosition.CenterParent;
            tradeScreen.ShowDialog(this);
        }
        private void change_Click(object sender, EventArgs e)
        {
            Item currentArmor = (Item)cboChange.SelectedItem;
            if (currentArmor != null) 
            { 
                game.ChangeArmor(currentArmor);
                acttxt.Text += "You changed yout armor to: " + currentArmor.Name + ".\n";
            }
            ChangeTexts();
            UpdateArmors();
        }
        private void btnQuest_Click(object sender, EventArgs e)
        {
            acttxt.Text += game.CheckQuest();
            ChangeTexts();
        }

        public GameSession GetSession()
        {
            return game;
        }
    }
}
