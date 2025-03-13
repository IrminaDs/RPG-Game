namespace game
{
    partial class TradeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            equipmentBindingSource = new BindingSource(components);
            characterBindingSource = new BindingSource(components);
            inventory = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Sell = new DataGridViewButtonColumn();
            Info = new DataGridViewButtonColumn();
            equipmentBindingSource1 = new BindingSource(components);
            player = new Label();
            equipmentBindingSource2 = new BindingSource(components);
            lab = new Label();
            Trader = new DataGridView();
            cls = new Button();
            trd = new Label();
            ID2 = new DataGridViewTextBoxColumn();
            Item2 = new DataGridViewTextBoxColumn();
            Price2 = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Buy = new DataGridViewButtonColumn();
            Info2 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)characterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Trader).BeginInit();
            SuspendLayout();
            // 
            // equipmentBindingSource
            // 
            equipmentBindingSource.DataSource = typeof(Engine.Equipment);
            // 
            // characterBindingSource
            // 
            characterBindingSource.DataSource = typeof(Engine.Character);
            // 
            // inventory
            // 
            inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventory.Columns.AddRange(new DataGridViewColumn[] { id, Item, Price, Quantity, Sell, Info });
            inventory.Location = new Point(13, 43);
            inventory.Name = "inventory";
            inventory.RowHeadersVisible = false;
            inventory.RowHeadersWidth = 51;
            inventory.RowTemplate.Height = 29;
            inventory.Size = new Size(330, 216);
            inventory.TabIndex = 0;
            inventory.CellContentClick += inventory_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 50;
            // 
            // Item
            // 
            Item.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item.DataPropertyName = "Name";
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 150;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 60;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Qty";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 50;
            // 
            // Sell
            // 
            Sell.DataPropertyName = "ID";
            Sell.HeaderText = "";
            Sell.MinimumWidth = 6;
            Sell.Name = "Sell";
            Sell.Text = "Sell";
            Sell.UseColumnTextForButtonValue = true;
            Sell.Width = 67;
            // 
            // Info
            // 
            Info.HeaderText = "Info";
            Info.MinimumWidth = 6;
            Info.Name = "Info";
            Info.Visible = false;
            Info.Width = 125;
            Info.DataPropertyName = "Info";
            // 
            // equipmentBindingSource1
            // 
            equipmentBindingSource1.DataSource = typeof(Engine.Equipment);
            // 
            // player
            // 
            player.AutoSize = true;
            player.Location = new Point(139, 13);
            player.Name = "player";
            player.Size = new Size(70, 20);
            player.TabIndex = 2;
            player.Text = "Inventory";
            // 
            // equipmentBindingSource2
            // 
            equipmentBindingSource2.DataSource = typeof(Engine.Equipment);
            // 
            // lab
            // 
            lab.Location = new Point(0, 0);
            lab.Name = "lab";
            lab.Size = new Size(100, 23);
            lab.TabIndex = 8;
            // 
            // Trader
            // 
            Trader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Trader.Columns.AddRange(new DataGridViewColumn[] { ID2, Item2, Price2, Qty, Buy, Info2 });
            Trader.Location = new Point(353, 43);
            Trader.Name = "Trader";
            Trader.RowHeadersVisible = false;
            Trader.RowHeadersWidth = 51;
            Trader.RowTemplate.Height = 29;
            Trader.Size = new Size(330, 216);
            Trader.TabIndex = 4;
            Trader.CellContentClick += Trader_CellContentClick;
            // 
            // cls
            // 
            cls.Location = new Point(283, 270);
            cls.Name = "cls";
            cls.Size = new Size(136, 29);
            cls.TabIndex = 6;
            cls.Text = "Close";
            cls.UseVisualStyleBackColor = true;
            cls.Click += cls_Click;
            // 
            // trd
            // 
            trd.AutoSize = true;
            trd.Location = new Point(481, 13);
            trd.Name = "trd";
            trd.Size = new Size(0, 20);
            trd.TabIndex = 7;
            // 
            // ID2
            // 
            ID2.DataPropertyName = "ID";
            ID2.HeaderText = "ID";
            ID2.MinimumWidth = 6;
            ID2.Name = "ID2";
            ID2.ReadOnly = true;
            ID2.Visible = false;
            ID2.Width = 50;
            // 
            // Item2
            // 
            Item2.DataPropertyName = "Name";
            Item2.HeaderText = "Item";
            Item2.MinimumWidth = 6;
            Item2.Name = "Item2";
            Item2.ReadOnly = true;
            Item2.Width = 150;
            // 
            // Price2
            // 
            Price2.DataPropertyName = "Price";
            Price2.HeaderText = "Price";
            Price2.MinimumWidth = 6;
            Price2.Name = "Price2";
            Price2.ReadOnly = true;
            Price2.Width = 70;
            // 
            // Qty
            // 
            Qty.DataPropertyName = "Quantity";
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Visible = false;
            Qty.Width = 50;
            // 
            // Buy
            // 
            Buy.DataPropertyName = "ID";
            Buy.HeaderText = "";
            Buy.MinimumWidth = 6;
            Buy.Name = "Buy";
            Buy.Text = "Buy";
            Buy.UseColumnTextForButtonValue = true;
            Buy.Width = 47;
            // 
            // Info2
            // 
            Info2.DataPropertyName = "Info";
            Info2.HeaderText = "";
            Info2.MinimumWidth = 6;
            Info2.Name = "Info2";
            Info2.Width = 60;
            Info2.Text = "Info";
            Info2.UseColumnTextForButtonValue = true;
            // 
            // TradeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 311);
            Controls.Add(trd);
            Controls.Add(cls);
            Controls.Add(Trader);
            Controls.Add(lab);
            Controls.Add(player);
            Controls.Add(inventory);
            Name = "TradeScreen";
            Text = "TradeScreen";
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)characterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)equipmentBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Trader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource equipmentBindingSource;
        private BindingSource characterBindingSource;
        private DataGridView inventory;
        private BindingSource equipmentBindingSource1;
        private Label player;
        private BindingSource equipmentBindingSource2;
        private Label lab;
        private DataGridView Trader;
        private Button cls;
        private Label trd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn Sell;
        private DataGridViewButtonColumn Info;
        private DataGridViewTextBoxColumn ID2;
        private DataGridViewTextBoxColumn Item2;
        private DataGridViewTextBoxColumn Price2;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewButtonColumn Buy;
        private DataGridViewButtonColumn Info2;
    }
}